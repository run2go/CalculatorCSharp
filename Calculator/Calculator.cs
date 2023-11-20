using org.matheval; //Package used to evaluate equations
using Microsoft.Win32; //Registry checks (Used to get system theme)
using System.Text; //Used for StringBuilder, see Conversion Class
using System.Text.Json; //Handle JSON formatted responses
using System.Text.RegularExpressions; //Regex Packet to detect Binary & Hex
using System.Diagnostics; //Access explorer.exe to open URLs in default browser
using System.Globalization; //Get System Localization, grab default Comma character
using System.Net; //Required to check the GitHub Repository
using System.Numerics; //Used by BigInteger, also Conversion Class
using System.Runtime.InteropServices; //Darkmode detection, used to update titlebar
using System.Timers; //Used to Autocheck for Updates every 10min
//update check periodically
//resize fonts universally
//allow selection * delete/backspace or typing something, don't affect the first 2 chars, only affect InputGet()
//handle shortcuts (CTRL+key) differently
//2(3-1) => 2*(3-1)

namespace Calculator
{
    public partial class Interface : Form
    {
        internal Interface()
        {
            InitializeComponent();
            InitializeAttributes();
        }
        const string ProjectName = "Calculator";
        const string ProjectAuthor = "run2go";
        readonly string ProjectWebsite = $"https://github.com/{ProjectAuthor}/{ProjectName}/tree/Latest";
        readonly string ProjectAPI = $"https://api.github.com/repos/{ProjectAuthor}/{ProjectName}";
        readonly string SymbolComma = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        readonly string SymbolGroupSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
        string lastResult = "0";
        int baseCurrent = 10;
        private void InitializeAttributes()
        {
            if ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1)! == 0) ColorToggle(); MenuEditDarkmode.Checked = !MenuEditDarkmode.Checked;
            btCom.Text = SymbolComma;
            StripMenuVersion.Text = $"v{ProductVersion} ~❤️";
            KeyPress += new KeyPressEventHandler(Interface_KeyPress!); //Default Input
            KeyDown += new KeyEventHandler(Interface_KeyDown!); //Special Characters & Key Combinations
            KeyPreview = true; // Set KeyPreview property to true to capture keyboard events at the form level
            BtClear_Click(this, null!);
            SwitchMode(MenuModePro, null!);
            //Utility.UpdateCheck("https://github.com/run2go/Calculator");
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
                        case Keys.Enter: Calculate(); break;
                        case Keys.Back:
                        case Keys.Delete: InputDelete(); break;
                        case Keys.Add:
                        case Keys.Oemplus: InputAddOperatorRight("+"); break;
                        //case Keys.Subtract:
                        case Keys.OemMinus: InputAddOperatorRight("-"); break;
                        //case Keys.Multiply:
                        case Keys.OemPipe: InputAddOperatorRight("*"); break;
                        //case Keys.Divide:
                        case Keys.OemBackslash: InputAddOperatorRight("/"); break;
                        case Keys.Oemcomma:
                        case Keys.OemPeriod: InputAddOperatorRight(SymbolComma); break; //Get locale symbol for commas 
                    }
                }
                //InputFocus();
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private void Calculate()
        {
            try
            {
                if (SymbolGet() == ">") EvalAdd(InputGet());
                SymbolSet("=");
                Evaluation evaluation = new Evaluation();
                string sanitizedEvaluation = evaluation.Sanitize(EvalGet(), baseCurrent);
                EvalSet((MenuEditDebug.Checked) ? EvalGet() : sanitizedEvaluation);
                EvalSet(sanitizedEvaluation);

                Expression equation = new Expression(EvalGet());
                string result = equation.Eval().ToString()!;
                InputSet((MenuModePro.Checked) ? Converter.ConvertBase(result, 10, baseCurrent) : result);
                lastResult = result;

                if (MenuModePro.Checked) DisplayUpdate();
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private string SymbolGet() { return txtSymbol.Text; } //Get the indicator symbol
        private void SymbolSet(string symbol) { txtSymbol.Text = symbol; }
        private string EvalGet() { return txtEval.Text; } //Get current Equation
        private void EvalAdd(string text) { txtEval.Text += text; InputFocus(); }
        private void EvalSet(string text) { txtEval.Text = text; InputFocus(); }
        private string InputGet() { return txtInput.Text; } //Get the current input
        private void InputAdd(string text) { txtInput.Text += text; InputFocus(); DisplayUpdate(); }
        private void InputSet(string text) { txtInput.Text = text; InputFocus(); DisplayUpdate(); }
        private void InputDelete()
        {
            if (txtInput.SelectedText.Length > 0) txtInput.SelectedText = string.Empty;
            else if (InputGet().Length > 0)
            {
                SymbolSet(">");
                InputSet(InputGet().Substring(0, InputGet().Length - 1));
            }
        }
        private void InputAddNum(string num)
        {
            if (SymbolGet() == "=")
            {
                EvalSet(string.Empty);
                SymbolSet(">");
                InputSet(num);
            }
            else InputAdd(num);
        }
        private void InputAddOperatorLeft(string op)
        {
            if (SymbolGet() == "=") EvalSet((Regex.IsMatch(EvalGet().Substring(EvalGet().Length), @"[^\dA-F]$")) ? $"*{op}{InputGet()}" : $"{op}{InputGet()}"); //Add * if the last eval char was a number
            else EvalAdd((Regex.IsMatch(EvalGet().Substring(EvalGet().Length), @"[^\dA-F]$")) ? $"*{op}{InputGet()}" : $"{op}{InputGet()}"); //Add * if the last eval char was a number
            SymbolSet(">");
            InputSet(string.Empty);
        }
        private void InputAddOperatorRight(string op)
        {
            if (SymbolGet() == "=") EvalSet(InputGet() + op);
            else EvalAdd(InputGet() + op);
            SymbolSet(">");
            InputSet(string.Empty);
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
                if (MenuModePro.Checked)
                {
                    string input = InputGet();
                    switch (baseCurrent)
                    {
                        case 16: input = Regex.Replace(input, $@"[^\dA-F{SymbolComma}]", ""); break;
                        case 10: input = Regex.Replace(input, $@"[^\d{SymbolComma}]", ""); break;
                        case 8: input = Regex.Replace(input, $@"[^0-7{SymbolComma}]", ""); break;
                        case 2: input = Regex.Replace(input, $@"[^0-1{SymbolComma}]", ""); break;
                    }
                    btBase16.Text = Converter.ConvertBase(input, baseCurrent, 16);
                    btBase10.Text = Converter.ConvertBase(input, baseCurrent, 10);
                    btBase8.Text = Converter.ConvertBase(input, baseCurrent, 8);
                    btBase2.Text = Regex.Replace(Converter.ConvertBase(input, baseCurrent, 2), ".{4}", "$0 "); //Use regex replace to append spaces every 4 digits
                }
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
        private void StatusText(string status) { StripMenuVersion.Text = (status.Length > 0) ? $"{status} v{ProductVersion} ~❤️" : $"v{ProductVersion} ~❤️"; }
        public void HandleError(Exception ex) { SymbolSet("⚠️"); if (MenuEditDebug.Checked) MessageBox.Show(ex.ToString(), $"Debug: {ex.GetType()}"); }
        private void BaseUpdate(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            baseCurrent = int.Parse(radioButton.Name.Substring(6));
            Button[] button = { bt0, bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, btA, btB, btC, btD, btE, btF };
            for (int i = baseCurrent; i < button.Length; i++) { button[i].Enabled = false; button[i].ForeColor = Utility.ColorOffset(bt0.ForeColor, 200, MenuEditDarkmode.Checked); } //Disable unused buttons
            for (int i = 0; i < baseCurrent; i++) { button[i].Enabled = true; button[i].ForeColor = bt0.ForeColor; } //Enable required buttons
        }
        private void MenuEditTopmost_Click(object ob, EventArgs e) { TopMost = MenuEditTopmost.Checked = !MenuEditTopmost.Checked; }
        private void MenuDarkmode_Click(object ob, EventArgs e) { ColorToggle(); MenuEditDarkmode.Checked = !MenuEditDarkmode.Checked; }
        private void MenuEditDebug_Click(object ob, EventArgs e) { StatusText((MenuEditDebug.Checked = !MenuEditDebug.Checked) ? "[Debug Mode]" : ""); }
        private void StripMenuVersion_Click(object ob, EventArgs e) { Process.Start("explorer.exe", ProjectWebsite); }
        private void SwitchMode(object ob, EventArgs e)
        {
            string mode = ((ToolStripMenuItem)ob).Name;
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
        private void BtCalc_Click(object ob, EventArgs e) { Calculate(); }
        private void BtDelete_Click(object ob, EventArgs e) { InputDelete(); }
        private void BtClear_Click(object ob, EventArgs e) { SymbolSet(">"); InputSet(""); EvalSet(""); }
        private void BtCopy_Click(object ob, EventArgs e) { InputAddNum(lastResult); }
        private void BtCom_Click(object ob, EventArgs e) { InputAddNum(SymbolComma); }
        private void BtFactorial_Click(object ob, EventArgs e) { InputAddNum("!"); }
        private void BtReciprocal_Click(object ob, EventArgs e) { InputAddOperatorLeft("1/"); }
        private void BtPow_Click(object ob, EventArgs e) { InputAddOperatorRight("^"); }
        private void BtOperatorRight_Click(object ob, EventArgs e) { Button bt = (Button)ob; InputAddOperatorRight(bt.Text); }
        private void BtOperatorLeft_Click(object ob, EventArgs e) { Button bt = (Button)ob; InputAddOperatorLeft(bt.Text); }
        private void BtNegate_Click(object ob, EventArgs e) { SymbolSet(">"); InputSet(InputGet().Length >= 1 && InputGet()[0] == '-' ? InputGet().Substring(1) : '-' + InputGet()); } //Negate the current input
        private void BtNumeric_Click(object ob, EventArgs e) { Button bt = (Button)ob; InputAddNum(bt.Name.Substring(2, 1)); }
        private void TxtBox_SizeTextChanged(object ob, EventArgs e) { Utility.TextBoxResizeContents(ob); } //TextBox Autoresize Contents
        private void Label_SizeTextChanged(object ob, EventArgs e) { Utility.LabelResizeContents(ob); } //TextBox Autoresize Contents
        private void Bt_SizeChanged(object ob, EventArgs e) { Utility.ButtonResizeContents(ob); } //Button Autoresize Contents
        private void Bt_SizeChanged_HelperNumeric(object ob, EventArgs e) { Utility.ButtonResizeHelper(ob, bt0); } //Numeric Buttons Autoresize Helper
        private void Bt_SizeChanged_HelperOperator(object ob, EventArgs e) { Utility.ButtonResizeHelper(ob, btCom); } //Operator Buttons Autoresize Helper
        private void BtBase_Click(object ob, EventArgs e) { Button bt = (Button)ob; Clipboard.SetText(bt.Text); } //Copy Converted Bases
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
        internal static void LabelResizeContents(object sender)
        {
            Label label = (Label)sender;
            if (label.Text.Length > 0)
            {
                using (Graphics g = label.CreateGraphics()) // Create a temporary Graphics object to measure text size
                {
                    SizeF textSize = g.MeasureString(label.Text, label.Font); // Calculate the size of the text with the current font
                    float scaleX = label.ClientSize.Width / textSize.Width; // Calculate the scaling factor for both width and height
                    float scaleY = label.ClientSize.Height / textSize.Height;
                    label.Font = new Font(label.Font.FontFamily, label.Font.Size * Math.Min(scaleX, scaleY)); // Apply the new font to the TextBox
                }
            }
        }
        internal static void ButtonResizeContents(object sender)
        {
            Button button = (Button)sender;
            if (button.Width <= 0 || button.Height <= 0) return; // Ensure the button's width and height are greater than 0
            float maxFontSize = float.MaxValue; // Maximum font size
            using (Graphics g = button.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(button.Text, button.Font);
                if (textSize.Width <= 0 || textSize.Height <= 0) return; // Ensure that the width and height ratios are greater than 0
                float widthRatio = button.Width / textSize.Width;
                float heightRatio = button.Height / textSize.Height;
                float ratio = (int)(button.Font.Size * (Math.Min(widthRatio, heightRatio) / 100 * 60)); // Calculate the desired font size
                ratio = Math.Max(1, Math.Min(ratio, maxFontSize)); // Ensure that the calculated font size is within a valid range
                button.Font = new Font(button.Font.FontFamily, ratio, button.Font.Style);
            }
        }
        internal static void ButtonResizeHelper(object sender, Button bt)
        {
            Button button = (Button)sender;
            button.Font = new Font(bt.Font.FontFamily, bt.Font.Size, bt.Font.Style);
        }

        [DllImport("dwmapi.dll")] // Used for the following titlebar recoloring
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        internal static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = 19; //DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1
                if (IsWindows10OrGreater(18985)) attribute = 20; //DWMWA_USE_IMMERSIVE_DARK_MODE
                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }
            return false;
        }
        private static bool IsWindows10OrGreater(int build = -1) { return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build; }
    }
    internal partial class Evaluation
    {
        internal string Sanitize(string eval, int baseCurrent)
        {
            string[] elements = Regex.Split(eval.Trim(), @"^[\dA-F]+$"); //Split by Numeric & Non-Numeric parts
            for (int i = 0; i < elements.Length; i++) if (Utility.IsNumeric(elements[i])) elements[i] = Converter.ConvertBase(elements[i], baseCurrent, 10);
            eval = string.Join("", elements);
            eval = eval.Replace('x', '*').Replace(',', '.').Replace('[', '(').Replace('{', '(').Replace(']', ')').Replace('}', ')');
            eval = Regex.Replace(eval, @"(?<=[\dA-F()√π])[\(√π]", "*$0"); // Insert missing multiplier operators
            eval = eval.Replace("π", "PI()"); //Sanitize
            eval = Regex.Replace(eval, @"(\d+|[0-9A-F]+)!+", match =>
            { // Handle Factorials
                string innerMatch = match.Groups[1].Value;
                int numberOfExclamationMarks = match.Value.Count(c => c == '!');
                for (int i = 0; i < numberOfExclamationMarks; i++) innerMatch = $"FACT({innerMatch})";
                return innerMatch;
            });
            eval = Regex.Replace(eval, @"√+([0-9A-F]+)", match =>
            { // Handle Square Roots
                string innerMatch = match.Groups[1].Value;
                int numberOfSquareRoots = match.Value.Count(c => c == '√');
                innerMatch = $"SQRT({innerMatch})"; //'√' is a leading symbol
                for (int i = 1; i < numberOfSquareRoots; i++) innerMatch = $"SQRT({innerMatch})";
                return innerMatch;
            });
            return eval;
        }
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