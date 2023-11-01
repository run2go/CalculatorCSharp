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
using Microsoft.VisualBasic;
//update check periodically
//resize fonts universally
//subnetting extra <- Optional
//allow selection * delete/backspace or typing something, don't affect the first 2 chars, only affect InputGet()
//handle shortcuts (CTRL+key) differently
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
            this.KeyPress += new KeyPressEventHandler(Interface_KeyPress!); //Default Input
            this.KeyDown += new KeyEventHandler(Interface_KeyDown!); //Special Characters & Key Combinations
            this.KeyPreview = true; // Set KeyPreview property to true to capture keyboard events at the form level
            InputReplace(">", "");
            SwitchMode(MenuModeSim);
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
                txtInput.Text = $"= {InputGet()}";

                string dataConversion = txtEval.Text.Trim();
                //string[] elements = Regex.Split(dataConversion, @"(?<=[+*/%^()\-])|(?=[+*/%^()\-])");
                string[] elements = Regex.Split(dataConversion, @"[^0-9A-F]+");
                for (int i = 0; i < elements.Length; i++)
                {
                    if (Utility.IsNumeric(elements[i]))
                    {
                        string convertedNumber = Converter.ConvertBase(elements[i], baseCurrent, 10);
                        elements[i] = convertedNumber;
                    }
                }
                dataConversion = string.Join("", elements);

                string dataSanitization = dataConversion.Replace(',', '.').Replace('[', '(').Replace('{', '(').Replace(']', ')').Replace('}', ')').Replace("π", "PI()"); //Sanitize
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
                if (MenuEditDebug.Checked) txtEval.Text = dataSanitization;
                if (txtEval.Text != string.Empty)
                {
                    Expression equation = new Expression(dataSanitization);
                    lastResult = equation.Eval().ToString()!;
                    InputReplace("=", lastResult);
                }
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
            txtInput.Text = $"{symbol} {text}"; InputFocus();
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
        private void BaseUpdate(int baseNew)
        {
            try
            {
                Button[] button = { bt0, bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, btA, btB, btC, btD, btE, btF };
                foreach (Button bt in button) bt.Enabled = false;
                switch (baseNew)
                {
                    case 16: for (int i = 0; i < 16; i++) button[i].Enabled = true; break;
                    case 10: for (int i = 0; i < 10; i++) button[i].Enabled = true; break;
                    case 8: for (int i = 0; i < 8; i++) button[i].Enabled = true; break;
                    case 2: for (int i = 0; i < 2; i++) button[i].Enabled = true; break;
                }
                baseCurrent = baseNew;
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private void DisplayUpdate()
        {
            try
            {
                string input = InputGet();
                switch (baseCurrent)
                {
                    case 16: input = Regex.Replace(input.ToUpper(), "[^0-9A-F]", ""); break;
                    case 10: input = Regex.Replace(input, "[^0-9]", ""); break;
                    case 8: input = Regex.Replace(input, "[^0-7]", ""); break;
                    case 2: input = Regex.Replace(input, "[^0-1]", ""); break;
                }
                input = Regex.Replace(input.ToUpper(), "[^0-9A-F]", "");
                btHex.Text = Converter.ConvertBase(input, baseCurrent, 16);
                btDec.Text = Converter.ConvertBase(input, baseCurrent, 10);
                btOct.Text = Converter.ConvertBase(input, baseCurrent, 8);
                btBin.Text = Converter.ConvertBase(input, baseCurrent, 2);
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private void ColorToggle()
        {
            foreach (Control item in this.GetAllElements())
            {
                Button? button = item as Button;
                if (button != null) button.FlatAppearance.BorderColor = Utility.InvertColor(button.FlatAppearance.BorderColor);
                item.BackColor = Utility.InvertColor(item.BackColor);
                item.ForeColor = Utility.InvertColor(item.ForeColor);
            }
            Utility.UseImmersiveDarkMode(Handle, !MenuEditDarkmode.Checked);
        }
        private void ButtonResize()
        {
            foreach (Control item in this.GetAllElements())
            {
                Button? button = item as Button;
                Utility.ButtonResizeContents(button!);
            }
        }
        private void StatusText(bool visibility, string status) { StripMenuVersion.Text = (visibility) ? $"{status} v{ProductVersion} ~❤️" : $"v{ProductVersion} ~❤️"; }
        public void HandleError(Exception ex)
        {
            if (MenuEditDebug.Checked) MessageBox.Show(ex.ToString(), $"Debug: {ex.GetType()}");
            InputReplace("⚠️", InputGet());
        }
        private void MenuEditTopmost_Click(object sender, EventArgs e) { TopMost = MenuEditTopmost.Checked = !MenuEditTopmost.Checked; }
        private void MenuDarkmode_Click(object sender, EventArgs e) { ColorToggle(); MenuEditDarkmode.Checked = !MenuEditDarkmode.Checked; }
        private void MenuEditDebug_Click(object sender, EventArgs e) { StatusText((MenuEditDebug.Checked = !MenuEditDebug.Checked), "[Debug Mode]"); }
        private void StripMenuVersion_Click(object sender, EventArgs e) { Process.Start("explorer.exe", ProductWebsite); }
        private void SwitchMode(object sender)
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
                rbDec.Checked = true;
            }
        }
        private void MenuModeSim_Click(object sender, EventArgs e) { SwitchMode(sender); }
        private void MenuModeAdv_Click(object sender, EventArgs e) { SwitchMode(sender); }
        private void MenuModePro_Click(object sender, EventArgs e) { SwitchMode(sender); }
        //Operators
        private void btCalc_Click(object sender, EventArgs e) { Calc(); }
        private void btDelete_Click(object sender, EventArgs e) { InputDelete(); }
        private void btClear_Click(object sender, EventArgs e) { InputReplace(">", string.Empty); txtEval.Text = string.Empty; }
        private void btCopy_Click(object sender, EventArgs e) { InputAddNum(lastResult.ToString()); }
        private void btCom_Click(object sender, EventArgs e) { InputAddNum("."); }
        private void btAdd_Click(object sender, EventArgs e) { InputAddOperator("+", true); }
        private void btSub_Click(object sender, EventArgs e) { InputAddOperator("-", true); }
        private void btMul_Click(object sender, EventArgs e) { InputAddOperator("*", true); }
        private void btDiv_Click(object sender, EventArgs e) { InputAddOperator("/", true); }
        private void btPow_Click(object sender, EventArgs e) { InputAddOperator("^", true); }
        private void btModulo_Click(object sender, EventArgs e) { InputAddOperator("%", true); }
        private void btBracketOpen_Click(object sender, EventArgs e) { InputAddOperator("(", true); }
        private void btBracketClose_Click(object sender, EventArgs e) { InputAddOperator(")", true); }
        private void btPi_Click(object sender, EventArgs e) { InputAddOperator("π", true); }
        private void btFactorial_Click(object sender, EventArgs e) { InputAddOperator("!", true); }
        private void btSqrt_Click(object sender, EventArgs e) { InputAddOperator("√", false); }
        private void btReciprocal_Click(object sender, EventArgs e) { InputAddOperator("1/", false); }
        private void btNegate_Click(object sender, EventArgs e) { InputReplace(">", txtInput.Text.Length >= 3 && txtInput.Text[2] == '-' ? txtInput.Text.Substring(3) : '-' + InputGet()); } //Negate the current input
        //Base 2
        private void bt0_Click(object sender, EventArgs e) { InputAddNum("0"); }
        private void bt1_Click(object sender, EventArgs e) { InputAddNum("1"); }
        //Base 8
        private void bt2_Click(object sender, EventArgs e) { InputAddNum("2"); }
        private void bt3_Click(object sender, EventArgs e) { InputAddNum("3"); }
        private void bt4_Click(object sender, EventArgs e) { InputAddNum("4"); }
        private void bt5_Click(object sender, EventArgs e) { InputAddNum("5"); }
        private void bt6_Click(object sender, EventArgs e) { InputAddNum("6"); }
        private void bt7_Click(object sender, EventArgs e) { InputAddNum("7"); }
        //Base 10
        private void bt8_Click(object sender, EventArgs e) { InputAddNum("8"); }
        private void bt9_Click(object sender, EventArgs e) { InputAddNum("9"); }
        //Base 16
        private void btA_Click(object sender, EventArgs e) { InputAddNum("A"); }
        private void btB_Click(object sender, EventArgs e) { InputAddNum("B"); }
        private void btC_Click(object sender, EventArgs e) { InputAddNum("C"); }
        private void btD_Click(object sender, EventArgs e) { InputAddNum("D"); }
        private void btE_Click(object sender, EventArgs e) { InputAddNum("E"); }
        private void btF_Click(object sender, EventArgs e) { InputAddNum("F"); }
        //TextBox Autoresize Contents
        private void txtInput_SizeChanged(object sender, EventArgs e) { Utility.TextBoxResizeContents(sender, e); }
        private void txtInput_TextChanged(object sender, EventArgs e) { Utility.TextBoxResizeContents(sender, e); }
        private void txtEval_SizeChanged(object sender, EventArgs e) { Utility.TextBoxResizeContents(sender, e); }
        private void txtEval_TextChanged(object sender, EventArgs e) { Utility.TextBoxResizeContents(sender, e); }
        private void textProgrammer_SizeChanged(object sender, EventArgs e) { Utility.TextBoxResizeContents(sender, e); }
        private void textProgrammer_TextChanged(object sender, EventArgs e) { Utility.TextBoxResizeContents(sender, e); }
        //Programmer Buttons
        private void btHex_Click(object sender, EventArgs e) { Clipboard.SetText(btHex.Text); }
        private void btDec_Click(object sender, EventArgs e) { Clipboard.SetText(btDec.Text); }
        private void btOct_Click(object sender, EventArgs e) { Clipboard.SetText(btOct.Text); }
        private void btBin_Click(object sender, EventArgs e) { Clipboard.SetText(btBin.Text); }
        private void rbHex_CheckedChanged(object sender, EventArgs e) { BaseUpdate(16); }
        private void rbDec_CheckedChanged(object sender, EventArgs e) { BaseUpdate(10); }
        private void rbOct_CheckedChanged(object sender, EventArgs e) { BaseUpdate(8); }
        private void rbBin_CheckedChanged(object sender, EventArgs e) { BaseUpdate(2); }
    }
    internal static class Utility
    {
        internal static bool IsNumeric(string value) { return value.All(char.IsNumber); }
        internal static Color InvertColor(this Color color) { return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B); }
        internal static IEnumerable<Control> GetAllElements(this Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(GetAllElements).Concat(controls);
        }
        internal static void TextBoxResizeContents(object sender, EventArgs e)
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
                        float newSize = textBox.Font.Size * Math.Min(scaleX, scaleY); // Calculate the new font size using the minimum scaling factor
                        textBox.Font = new Font(textBox.Font.FontFamily, newSize); // Apply the new font to the TextBox
                    }
                }
            }
            catch { } // Dismiss
        }
        internal static void ButtonResizeContents(Button button)
        {
            try
            {
                int fontSize = 10; // Set a default font size
                using (Graphics g = button.CreateGraphics()) // Calculate the desired font size based on the button's width and height
                {
                    SizeF textSize = g.MeasureString(button.Text, button.Font);
                    float widthRatio = button.Width / textSize.Width;
                    float heightRatio = button.Height / textSize.Height;
                    float ratio = Math.Min(widthRatio, heightRatio);
                    button.Font = new Font(button.Font.FontFamily, (int)(button.Font.Size * ratio), button.Font.Style); // Create a new font with the calculated font size and assign it to the button
                }
            }
            catch { } // Dismiss
        }
        [DllImport("dwmapi.dll")]
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
        private static readonly Dictionary<char, int> CharToInt = new Dictionary<char, int>
        {
            { '0', 0 }, { '1', 1 }, { '2', 2 }, { '3', 3 },
            { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 },
            { '8', 8 }, { '9', 9 }, { 'A', 10 }, { 'B', 11 },
            { 'C', 12 }, { 'D', 13 }, { 'E', 14 }, { 'F', 15 }
        };
        private static readonly Dictionary<int, char> IntToChar = new Dictionary<int, char>
        {
            { 0, '0' }, { 1, '1' }, { 2, '2' }, { 3, '3' },
            { 4, '4' }, { 5, '5' }, { 6, '6' }, { 7, '7' },
            { 8, '8' }, { 9, '9' }, { 10, 'A' }, { 11, 'B' },
            { 12, 'C' }, { 13, 'D' }, { 14, 'E' }, { 15, 'F' }
        };
        internal static string ConvertBase(string input, int fromBase, int toBase)
        {
            input = input.ToUpper();
            BigInteger value = 0;
            for (int i = input.Length - 1; i >= 0; i--) // Convert input to decimal (base 10)
            {
                char c = input[i];
                int digitValue = CharToInt[c];
                value += digitValue * BigInteger.Pow(fromBase, input.Length - 1 - i);
            }
            StringBuilder result = new StringBuilder(); // Convert decimal to the desired base
            while (value > 0)
            {
                result.Insert(0, IntToChar[(int)(value % toBase)]);
                value /= toBase;
            }
            return result.Length > 0 ? result.ToString() : "0";
        }
    }
}