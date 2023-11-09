using org.matheval; //Package used to evaluate equations
using System.Text; //Used for StringBuilder, see Conversion Class
using System.Numerics; //Used by BigInteger, also Conversion Class
using System.Text.RegularExpressions; //Regex Packet to detect Binary & Hex
using System.Globalization; //Get System Localization, grab default Comma character
using Microsoft.Win32; //Registry checks (Used to get system theme)
using System.Runtime.InteropServices; //Darkmode detection, used to update titlebar
using System.Diagnostics; //Access explorer.exe to open URLs in default browser
using System.Net; //Required to check the GitHub Repository
using System.Text.Json; //Handle JSON formatted responses
using System.Timers; //Used to Autocheck for Updates every 10min
//update check periodically
//resize fonts universally
//subnetting extra <- Optional
//allow selection * delete/backspace or typing something, don't affect the first 2 chars, only affect InputGet()
//handle shortcuts (CTRL+key) differently
//2(3-1) => 2*(3-1)
//error msgs add spaces

namespace Calculator
{
    public partial class Interface : Form
    {
        internal Interface()
        {
            InitializeComponent();
            InitializeAttributes();
        }
        string ProductAuthor = "run2go";
        string ProductWebsite = "https://github.com/run2go/Calculator/tree/Latest";
        string lastResult = "0";
        int baseCurrent = 10;
        private void InitializeAttributes()
        {
            if ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1)! == 0) ColorToggle(); MenuEditDarkmode.Checked = !MenuEditDarkmode.Checked;
            btCom.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            StripMenuVersion.Text = $"v{ProductVersion} ~❤️";
            KeyPress += new KeyPressEventHandler(Interface_KeyPress!); //Default Input
            KeyDown += new KeyEventHandler(Interface_KeyDown!); //Special Characters & Key Combinations
            KeyPreview = true; // Set KeyPreview property to true to capture keyboard events at the form level
            InputReplace(">", string.Empty);
            SwitchMode(MenuModeSim, null!);
            //UpdateCheck("https://github.com/run2go/Calculator");
        }
        private void Interface_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtInput.SelectedText.Length > 0) txtInput.SelectedText = $"{e.KeyChar}";
                else if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) InputAddNum($"{e.KeyChar}");
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A: txtInput.SelectAll(); break;
                        case Keys.C: if (!string.IsNullOrEmpty(lastResult)) Clipboard.SetText(lastResult); break;
                        case Keys.V: if (Clipboard.ContainsText(TextDataFormat.Text)) InputAdd(Clipboard.GetText(TextDataFormat.Text)); break;
                    }
                }
                else
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Enter: Calc(); break;
                        case Keys.Back:
                        case Keys.Delete: InputDelete(); break;
                        case Keys.Add:
                        case Keys.Oemplus: InputAddOperator("+", true); break;
                        //case Keys.Subtract:
                        case Keys.OemMinus: InputAddOperator("-", true); break;
                        //case Keys.Multiply:
                        case Keys.OemPipe: InputAddOperator("*", true); break;
                        //case Keys.Divide:
                        case Keys.OemBackslash: InputAddOperator("/", true); break;
                        case Keys.Oemcomma:
                        case Keys.OemPeriod: InputAddOperator(btCom.Text, true); break; //Get locale symbol for commas 
                    }
                }
                InputFocus();
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private void Calc()
        {
            try
            {
                if (SymbolGet() == ">") txtEval.Text += InputGet();
                string dataSanitization = txtEval.Text.Trim();
                string[] elements = Regex.Split(dataSanitization, @"^[0-9A-F]+$");
                for (int i = 0; i < elements.Length; i++) if (Utility.IsNumeric(elements[i])) elements[i] = Converter.ConvertBase(elements[i], baseCurrent, 10);
                dataSanitization = string.Join("", elements).Replace('x', '*').Replace(',', '.').Replace('[', '(').Replace('{', '(').Replace(']', ')').Replace('}', ')').Replace("π", "PI()"); //Sanitize
                dataSanitization = Regex.Replace(dataSanitization, @"(?<=[^0-9A-F)])[\(πPS]", "*$0");// Insert * before (,π,P,S if the leading character is NOT 0-9A-F or )
                dataSanitization = Regex.Replace(dataSanitization, @"(\d+|[0-9A-F]+)!+", match =>
                { // Handle Factorials
                    string innerMatch = match.Groups[1].Value;
                    int numberOfExclamationMarks = match.Value.Count(c => c == '!');
                    for (int i = 0; i < numberOfExclamationMarks; i++) innerMatch = $"FACT({innerMatch})";
                    return innerMatch;
                });
                dataSanitization = Regex.Replace(dataSanitization, @"√+([0-9A-F]+)", match =>
                { // Handle Square Roots
                    string innerMatch = match.Groups[1].Value;
                    int numberOfSquareRoots = match.Value.Count(c => c == '√');
                    innerMatch = $"SQRT({innerMatch})"; //'√' is a leading symbol
                    for (int i = 1; i < numberOfSquareRoots; i++) innerMatch = $"SQRT({innerMatch})";
                    return innerMatch;
                });
                if (txtEval.Text != string.Empty)
                {
                    Expression equation = new Expression(dataSanitization);
                    string result = equation.Eval().ToString()!;
                    InputReplace("=", (MenuModePro.Checked) ? Converter.ConvertBase(result, 10, baseCurrent) : result);
                }
                if (MenuEditDebug.Checked) txtEval.Text = dataSanitization;
                if (MenuModePro.Checked) DisplayUpdate();
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private string SymbolGet() { return txtInput.Text.Substring(0, 1); } //Get the first character
        private void EvalAdd(string text) { txtEval.Text += text; InputFocus(); }
        private void EvalReplace(string text) { txtEval.Text = text; InputFocus(); }
        private string InputGet() { return txtInput.Text.Substring(2); } //Trim the first 2 characters
        private void InputAdd(string text)
        {
            txtInput.Text += text; InputFocus();
            if (MenuModePro.Checked) DisplayUpdate();
        }
        private void InputReplace(string symbol, string text)
        {
            txtInput.Text = $"{symbol} {text}";
            InputFocus();
            if (MenuModePro.Checked) DisplayUpdate();
        }
        private void InputDelete()
        {
            if (txtInput.SelectedText.Length > 0) txtInput.SelectedText = string.Empty;
            if (txtInput.Text.Length > 2) InputReplace(">", InputGet().Substring(0, InputGet().Length - 1));
        }
        private void InputAddNum(string num)
        {
            if (SymbolGet() == "=")
            {
                EvalReplace(string.Empty);
                InputReplace(">", num);
            }
            else InputAdd(num);
        }
        private void InputAddOperator(string op, bool left_or_right)
        {
            if (SymbolGet() == "=")
            {
                if (left_or_right) EvalReplace(InputGet() + op);
                else EvalReplace((Regex.IsMatch(txtEval.Text.Substring(txtEval.Text.Length), @"[^0-9A-F]$")) ? $"*{op}{InputGet()}" : $"{op}{InputGet()}"); //Add * if the last eval char was a number
            }
            else
            {
                if (left_or_right) EvalAdd(InputGet() + op);
                else EvalAdd((Regex.IsMatch(txtEval.Text.Substring(txtEval.Text.Length), @"[^0-9A-F]$")) ? $"*{op}{InputGet()}" : $"{op}{InputGet()}"); //Add * if the last eval char was a number
            }
            InputReplace(">", string.Empty);
        }
        private void InputFocus()
        {
            txtInput.SelectionStart = txtInput.Text.Length;
            txtInput.SelectionLength = 0;
            txtInput.Focus();
        }
        private void DisplayUpdate()
        {
            try
            {
                string input = InputGet();
                switch (baseCurrent)
                {
                    case 16: input = Regex.Replace(input, $"[^0-9A-F{btCom.Text}]", ""); break;
                    case 10: input = Regex.Replace(input, $"[^0-9{btCom.Text}]", ""); break;
                    case 8: input = Regex.Replace(input, $"[^0-7{btCom.Text}]", ""); break;
                    case 2: input = Regex.Replace(input, $"[^0-1{btCom.Text}]", ""); break;
                }
                btBase16.Text = Converter.ConvertBase(input, baseCurrent, 16);
                btBase10.Text = Converter.ConvertBase(input, baseCurrent, 10);
                btBase8.Text = Converter.ConvertBase(input, baseCurrent, 8);
                btBase2.Text = Regex.Replace(Converter.ConvertBase(input, baseCurrent, 2), ".{4}", "$0 ");
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private void ColorToggle()
        {
            Utility.UseImmersiveDarkMode(Handle, !MenuEditDarkmode.Checked);
            Size = new Size(Size.Width, Size.Height + 1); //Workaround to update Titlebar on W10
            Size = MinimumSize;
            foreach (Control item in this.GetAllElements())
            {
                Button? button = item as Button;
                if (button != null) button.FlatAppearance.BorderColor = Utility.ColorInvert(button.FlatAppearance.BorderColor);
                item.BackColor = Utility.ColorInvert(item.BackColor);
                item.ForeColor = Utility.ColorInvert(item.ForeColor);
            }
        }
        private void StatusText(bool visibility, string status) { StripMenuVersion.Text = (visibility) ? $"{status} v{ProductVersion} ~❤️" : $"v{ProductVersion} ~❤️"; }
        public void HandleError(Exception ex)
        {
            InputReplace("�", InputGet());
            if (MenuEditDebug.Checked) MessageBox.Show(ex.ToString(), $"Debug: {ex.GetType()}");
        }
        private void BaseUpdate(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            baseCurrent = int.Parse(radioButton.Name.Substring(6));
            Button[] button = { bt0, bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, btA, btB, btC, btD, btE, btF };
            for (int i = baseCurrent; i < button.Length; i++) { button[i].Enabled = false; button[i].ForeColor = Utility.ColorOffset(bt0.ForeColor, 200, MenuEditDarkmode.Checked); } //Disable unused buttons
            for (int i = 0; i < baseCurrent; i++) { button[i].Enabled = true; button[i].ForeColor = bt0.ForeColor; } //Enable required buttons
        }
        private void MenuEditTopmost_Click(object sender, EventArgs e) { TopMost = MenuEditTopmost.Checked = !MenuEditTopmost.Checked; }
        private void MenuDarkmode_Click(object sender, EventArgs e) { ColorToggle(); MenuEditDarkmode.Checked = !MenuEditDarkmode.Checked; }
        private void MenuEditDebug_Click(object sender, EventArgs e) { StatusText((MenuEditDebug.Checked = !MenuEditDebug.Checked), "[Debug Mode]"); }
        private void StripMenuVersion_Click(object sender, EventArgs e) { Process.Start("explorer.exe", ProductWebsite); }
        private void SwitchMode(object sender, EventArgs e)
        {
            string mode = ((ToolStripMenuItem)sender).Name;
            int[] colSize = new int[6];
            int[] rowSize = new int[6];
            switch (mode)
            {
                case "MenuModeSim": colSize = new int[] { 0, 8, 8, 8, 8, 0 }; rowSize = new int[] { 10, 0, 10, 10, 10, 10 }; break;
                case "MenuModeAdv": colSize = new int[] { 0, 8, 8, 8, 8, 8 }; rowSize = new int[] { 10, 10, 10, 10, 10, 10 }; break;
                case "MenuModePro": colSize = new int[] { 8, 8, 8, 8, 8, 8 }; rowSize = new int[] { 12, 12, 12, 12, 12, 12 }; break;
            }
            tableLayoutButtons.SuspendLayout();
            for (int i = 0; i < 6; i++)
            {
                if (i < tableLayoutButtons.ColumnStyles.Count) tableLayoutButtons.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, colSize[i]);
                if (i < tableLayoutButtons.RowStyles.Count) tableLayoutButtons.RowStyles[i] = new RowStyle(SizeType.Percent, rowSize[i]);
            }
            tableLayoutButtons.ResumeLayout(true);
            tableLayoutButtons.PerformLayout();
            Size = MinimumSize = new Size(colSize.Sum() * 8, rowSize.Sum() * 8);
            MenuModeSim.Checked = (mode == "MenuModeSim");
            MenuModeAdv.Checked = (mode == "MenuModeAdv");
            MenuModePro.Checked = (mode == "MenuModePro");
            tableLayoutMain.RowStyles[0] = new RowStyle(SizeType.Percent, MenuModePro.Checked ? 5 : 7);
            tableLayoutMain.RowStyles[1] = new RowStyle(SizeType.Percent, MenuModePro.Checked ? 10 : 12);
            tableLayoutMain.RowStyles[2] = new RowStyle(SizeType.Percent, MenuModePro.Checked ? 22 : 0);
            if (!MenuModePro.Checked)
            {
                Button[] button = { bt0, bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, btA, btB, btC, btD, btE, btF };
                for (int i = 0; i < 10; i++) button[i].Enabled = true;
                rbBase10.Checked = true;
            }
        }
        //Operators
        private void btCalc_Click(object sender, EventArgs e) { Calc(); }
        private void btDelete_Click(object sender, EventArgs e) { InputDelete(); }
        private void btClear_Click(object sender, EventArgs e) { InputReplace(">", string.Empty); txtEval.Text = string.Empty; }
        private void btCopy_Click(object sender, EventArgs e) { InputAddNum(lastResult); }
        private void btCom_Click(object sender, EventArgs e) { InputAddNum(btCom.Text); }
        private void btFactorial_Click(object sender, EventArgs e) { InputAddNum("!"); }
        private void btReciprocal_Click(object sender, EventArgs e) { InputAddOperator("1/", false); }
        private void btPow_Click(object sender, EventArgs e) { InputAddOperator("^", true); }
        private void btOperatorRight_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            InputAddOperator(button.Text, true);
        }
        private void btOperatorLeft_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            InputAddOperator(button.Text, false);
        }
        private void btNegate_Click(object sender, EventArgs e) { InputReplace(">", txtInput.Text.Length >= 3 && txtInput.Text[2] == '-' ? txtInput.Text.Substring(3) : '-' + InputGet()); } //Negate the current input
        private void btNumeric_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            InputAddNum(button.Name.Substring(2, 1));
        }
        private void txtBox_SizeTextChanged(object sender, EventArgs e) { Utility.TextBoxResizeContents(sender); } //TextBox Autoresize Contents
        private void bt_SizeChanged(object sender, EventArgs e) { Utility.ButtonResizeContents(sender); } //Button Autoresize Contents
        private void bt_SizeChanged_HelperNumeric(object sender, EventArgs e) { Utility.ButtonResizeHelper(sender, bt0); } //Numeric Buttons Autoresize Helper
        private void bt_SizeChanged_HelperOperator(object sender, EventArgs e) { Utility.ButtonResizeHelper(sender, btCom); } //Operator Buttons Autoresize Helper
        private void btBase_Click(object sender, EventArgs e) //Copy Converted Bases
        {
            Button button = (Button)sender;
            Clipboard.SetText(button.Text);
        }
    }
    internal static class Utility
    {
        internal static bool IsNumeric(string value) { return Regex.IsMatch(value, @"^[0-9A-F]+$", RegexOptions.IgnoreCase); }
        internal static Color ColorInvert(Color color) { return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B); }
        internal static Color ColorOffset(Color col, int off, bool negative) { return negative ? Color.FromArgb(col.A - off, col.R - off, col.B - off) : Color.FromArgb(col.A + off, col.R + off, col.B + off); }
        internal static IEnumerable<Control> GetAllElements(this Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(GetAllElements).Concat(controls);
        }
        internal static void TextBoxResizeContents(object sender)
        {
            try
            {
                RichTextBox textBox = (RichTextBox)sender;
                if (textBox.Text.Length > 0)
                {
                    using (Graphics g = textBox.CreateGraphics()) // Create a temporary Graphics object to measure text size
                    {
                        SizeF textSize = g.MeasureString(textBox.Text, textBox.Font); // Calculate the size of the text with the current font
                        float scaleX = textBox.ClientSize.Width / textSize.Width; // Calculate the scaling factor for both width and height
                        float scaleY = textBox.ClientSize.Height / textSize.Height;
                        textBox.Font = new Font(textBox.Font.FontFamily, textBox.Font.Size * Math.Min(scaleX, scaleY)); // Apply the new font to the TextBox
                    }
                }
            }
            catch { } // Dismiss
        }
        internal static void ButtonResizeContents(object sender)
        {
            try
            {
                Button button = (Button)sender;
                using (Graphics g = button.CreateGraphics()) // Calculate the desired font size based on the button's width and height
                {
                    SizeF textSize = g.MeasureString(button.Text, button.Font);
                    float widthRatio = button.Width / textSize.Width;
                    float heightRatio = button.Height / textSize.Height;
                    button.Font = new Font(button.Font.FontFamily, (int)(button.Font.Size * (Math.Min(widthRatio, heightRatio) / 100 * 80)), button.Font.Style); // Create a new font with the calculated font size and assign it to the button
                }
            }
            catch { } // Dismiss
        }
        internal static void ButtonResizeHelper(object sender, Button bt)
        {
            Button button = (Button)sender;
            button.Font = new Font(bt.Font.FontFamily, bt.Font.Size, bt.Font.Style);
        }
        [DllImport("dwmapi.dll")] // Used for the following titlebar recoloring
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        internal static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985)) attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }
            return false;
        }
        private static bool IsWindows10OrGreater(int build = -1) { return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build; }
    }
    internal class Converter
    {
        private static readonly Dictionary<char, int> CharToInt = new Dictionary<char, int> { { '0', 0 }, { '1', 1 }, { '2', 2 }, { '3', 3 }, { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 }, { '8', 8 }, { '9', 9 }, { 'A', 10 }, { 'B', 11 }, { 'C', 12 }, { 'D', 13 }, { 'E', 14 }, { 'F', 15 } };
        private static readonly Dictionary<int, char> IntToChar = new Dictionary<int, char> { { 0, '0' }, { 1, '1' }, { 2, '2' }, { 3, '3' }, { 4, '4' }, { 5, '5' }, { 6, '6' }, { 7, '7' }, { 8, '8' }, { 9, '9' }, { 10, 'A' }, { 11, 'B' }, { 12, 'C' }, { 13, 'D' }, { 14, 'E' }, { 15, 'F' } };
        internal static string ConvertBase(string input, int fromBase, int toBase)
        {
            input = input.ToUpper();
            BigInteger value = 0;
            for (int i = input.Length - 1; i >= 0; i--) value += CharToInt[input[i]] * BigInteger.Pow(fromBase, input.Length - 1 - i); // Convert input to decimal (base 10)
            StringBuilder result = new StringBuilder();
            while (value > 0) // Convert decimal to the desired base
            {
                result.Insert(0, IntToChar[(int)(value % toBase)]);
                value /= toBase;
            }
            return result.Length > 0 ? result.ToString() : "0";
        }
    }
}