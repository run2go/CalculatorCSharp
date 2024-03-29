﻿using org.matheval; //Package used to evaluate equations
using Microsoft.Win32; //Registry checks (Used to get system theme)
using System.Text; //Used for StringBuilder, see Conversion Class
using System.Text.RegularExpressions; //Regex Packet to detect Binary & Hex
using System.Diagnostics; //Access explorer.exe to open URLs in default browser
using System.Globalization; //Get System Localization, grab default Comma character
using System.Numerics; //Used by BigInteger, also Conversion Class
using System.Runtime.InteropServices; //Required for darkmode
//Move to WPF?
namespace Calculator {
    public partial class Interface : Form {
        const string ProjectName = "Calculator";
        const string ProjectAuthor = "run2go";
        const string ProjectVersion = "1.1.9";
        readonly string ProjectWebsite = $"https://github.com/{ProjectAuthor}/{ProjectName}/tree/Latest";
        readonly string ProjectFile = $"https://raw.githubusercontent.com/{ProjectAuthor}/{ProjectName}/master/{ProjectName}/{ProjectName}.cs"; //https://api.github.com/repos/
        readonly string SymbolComma = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        readonly string SymbolGroupSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
        string currentInput = "";
        string currentEval = "";
        string lastResult = "0";
        int baseCurrent = 10; //Decimal = Base 10
        internal Interface() {
            InitializeComponent();
            if ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1)! == 0) ColorToggle(); MenuEditDarkmode.Checked = !MenuEditDarkmode.Checked;
            BtCom.Text = SymbolComma;
            KeyPress += new KeyPressEventHandler(Interface_KeyPress!); //Allow normal input
            KeyDown += new KeyEventHandler(Interface_KeyDown!); //Handle special keys & shortcuts
            KeyPreview = true;
            SwitchMode(MenuViewSim, null!);
            StatusText(Utility.UpdateCheck(ProjectFile, ProjectVersion) ? "[Update Available]" : string.Empty);
        }
        private void Interface_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != 13 && e.KeyChar != 46 && e.KeyChar != 8) InputAdd($"{e.KeyChar}");
            switch (e.KeyChar)
            {
                case (char)Keys.Enter: Calculate(); break;
                case (char)Keys.Back:
                case (char)Keys.Delete: InputDelete(); break;
            }
        }
        private void Interface_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.C && !string.IsNullOrEmpty(lastResult)) Clipboard.SetText(lastResult);
            else if (e.Control && e.KeyCode == Keys.V && Clipboard.ContainsText(TextDataFormat.Text)) InputSet(Clipboard.GetText(TextDataFormat.Text));
        }
        private void Calculate() {
            try {
                if (SymbolGet(">")) {
                    EvalAdd(InputGet());
                    Evaluation evaluation = new Evaluation();
                    string sanitizedEvaluation = evaluation.Sanitize(EvalGet(), baseCurrent);
                    EvalSet((MenuEditDebug.Checked) ? sanitizedEvaluation : EvalGet()); //Display sanitized string when in debug mode
                    Expression equation = new Expression(sanitizedEvaluation);
                    string result = lastResult = equation.Eval().ToString()!;
                    result = (baseCurrent != 10) ? Converter.ConvertBase(result, 10, baseCurrent) : result; //string.Format("{0:#,0.####}", result)
                    InputSet(result);
                    SymbolSet("=");
                }
            }
            catch (Exception ex) { HandleError(ex); }
        }
        private bool SymbolGet(string symbol) { return (symbol == TbSymbol.Text); } //Get the indicator symbol
        private void SymbolSet(string symbol) { TbSymbol.Text = symbol; }
        private string EvalGet() { return currentEval; } //Get current Evaluation
        private void EvalAdd(string text) { TbEval.Text += text; currentEval += text; }
        private void EvalSet(string text) { TbEval.Text = currentEval = text; }
        private string InputGet() { return currentInput; } //Get the current input string
        private void InputAdd(string text) {
            if (SymbolGet("=")) TbEval.Text = TbInput.Text = currentInput = currentEval = string.Empty;
            if (Regex.IsMatch(text, $@"[^\dA-F,.]$")) {
                EvalAdd(InputGet() + text);
                TbInput.Text = currentInput = string.Empty;
            }
            else { TbInput.Text += text; currentInput += text; }
            DisplayUpdate();
            SymbolSet(">");
        }
        private void InputSet(string text) { TbInput.Text = currentInput = text; DisplayUpdate(); }
        private void InputDelete() { if (InputGet().Length > 0) TbInput.Text = currentInput = InputGet().Substring(0, InputGet().Length - 1); }
        private void InputAddLeft(string op) { EvalAdd((Regex.IsMatch(EvalGet().Substring(EvalGet().Length), @"[^\dA-F]$")) ? $"*{op}{InputGet()}" : $"{op}{InputGet()}"); } //Add * if the last eval char was a number
        private void DisplayUpdate() {
            string result = InputGet();
            try {
                if (MenuViewPro.Checked) {
                    switch (baseCurrent) {
                        case 16: result = Regex.Replace(result, $@"[^\dA-F{SymbolComma}]", ""); break;
                        case 10: result = Regex.Replace(result, $@"[^\d{SymbolComma}]", ""); break;
                        case 8: result = Regex.Replace(result, $@"[^0-7{SymbolComma}]", ""); break;
                        case 2: result = Regex.Replace(result, $@"[^0-1{SymbolComma}]", ""); break;
                    }
                    BtBase16.Text = Converter.ConvertBase(result, baseCurrent, 16);
                    BtBase10.Text = Converter.ConvertBase(result, baseCurrent, 10);
                    BtBase8.Text = Converter.ConvertBase(result, baseCurrent, 8);
                    BtBase2.Text = Regex.Replace(Converter.ConvertBase(result, baseCurrent, 2), ".{4}", "$0 "); //Use regex replace to append spaces every 4 digits
                }
            }
            catch (Exception ex) { HandleError(ex); }
            decimal decimalResult = 0;
            decimal.TryParse(result, out decimalResult);
            int count = BitConverter.GetBytes(decimal.GetBits(decimalResult)[3])[2];
            TbInput.Text = string.Format("{0:n" + count + "}", decimalResult);
        }
        private void ColorToggle() {
            Utility.UseImmersiveDarkMode(Handle, !MenuEditDarkmode.Checked);
            Size = new Size(Size.Width, Size.Height + 1); //Workaround to update Titlebar on W10
            Size = MinimumSize;
            foreach (Control item in this.GetAllElements()) {
                Button? button = item as Button;
                if (button != null) button.FlatAppearance.BorderColor = Utility.ColorInvert(button.FlatAppearance.BorderColor);
                item.BackColor = Utility.ColorInvert(item.BackColor);
                item.ForeColor = Utility.ColorInvert(item.ForeColor);
            }
        }
        private void StatusText(string status) { StripMenuVersion.Text = (status.Length > 0) ? $"{status} v{ProjectVersion}" : $"v{ProjectVersion}"; }
        public void HandleError(Exception ex) { SymbolSet("⚠️"); if (MenuEditDebug.Checked) MessageBox.Show(ex.ToString(), $"Debug: {ex.GetType()}"); }
        private void BaseUpdate(object sender, EventArgs e) {
            RadioButton radioButton = (RadioButton)sender;
            baseCurrent = int.Parse(radioButton.Name.Substring(6));
            Button[] button = { Bt0, Bt1, Bt2, Bt3, Bt4, Bt5, Bt6, Bt7, Bt8, Bt9, BtA, BtB, BtC, BtD, BtE, BtF };
            for (int i = baseCurrent; i < button.Length; i++) { button[i].Enabled = false; button[i].ForeColor = Utility.ColorOffset(Bt0.ForeColor, 200, MenuEditDarkmode.Checked); } //Disable unused buttons
            for (int i = 0; i < baseCurrent; i++) { button[i].Enabled = true; button[i].ForeColor = Bt0.ForeColor; } //Enable required buttons
        }
        private void SwitchMode(object ob, EventArgs e) {
            string view = ((ToolStripMenuItem)ob).Name;
            int[] colSize = new int[6];
            int[] rowSize = new int[6];
            switch (view) {
                case "MenuViewSim": colSize = new int[] { 0, 8, 8, 8, 8, 0 }; rowSize = new int[] { 10, 0, 10, 10, 10, 10 }; break;
                case "MenuViewAdv": colSize = new int[] { 0, 8, 8, 8, 8, 8 }; rowSize = new int[] { 10, 10, 10, 10, 10, 10 }; break;
                case "MenuViewPro": colSize = new int[] { 8, 8, 8, 8, 8, 8 }; rowSize = new int[] { 12, 12, 12, 12, 12, 12 }; break;
            }
            TableLayoutButtons.SuspendLayout();
            for (int i = 0; i < 6; i++) {
                if (i < TableLayoutButtons.ColumnStyles.Count) TableLayoutButtons.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, colSize[i]);
                if (i < TableLayoutButtons.RowStyles.Count) TableLayoutButtons.RowStyles[i] = new RowStyle(SizeType.Percent, rowSize[i]);
            }
            TableLayoutButtons.ResumeLayout(true);
            TableLayoutButtons.PerformLayout();
            Size = MinimumSize = new Size(colSize.Sum() * 8, rowSize.Sum() * 8);
            MenuViewSim.Checked = (view == "MenuViewSim");
            MenuViewAdv.Checked = (view == "MenuViewAdv");
            MenuViewPro.Checked = (view == "MenuViewPro");
            TableLayoutMain.RowStyles[0] = new RowStyle(SizeType.Percent, MenuViewPro.Checked ? 5 : 7);
            TableLayoutMain.RowStyles[1] = new RowStyle(SizeType.Percent, MenuViewPro.Checked ? 10 : 12);
            TableLayoutMain.RowStyles[2] = new RowStyle(SizeType.Percent, MenuViewPro.Checked ? 22 : 0);
            if (!MenuViewPro.Checked) {
                Button[] button = { Bt0, Bt1, Bt2, Bt3, Bt4, Bt5, Bt6, Bt7, Bt8, Bt9, BtA, BtB, BtC, BtD, BtE, BtF };
                for (int i = 0; i < 10; i++) button[i].Enabled = true;
                RbBase10.Checked = true;
            }
        }
        private void MenuEditTopmost_Click(object ob, EventArgs e) { TopMost = MenuEditTopmost.Checked = !MenuEditTopmost.Checked; }
        private void MenuDarkmode_Click(object ob, EventArgs e) { ColorToggle(); MenuEditDarkmode.Checked = !MenuEditDarkmode.Checked; }
        private void MenuEditDebug_Click(object ob, EventArgs e) { StatusText((MenuEditDebug.Checked = !MenuEditDebug.Checked) ? "[Debug Mode]" : ""); }
        private void StripMenuVersion_Click(object ob, EventArgs e) { Process.Start("explorer.exe", ProjectWebsite); }
        private void BtCalc_Click(object ob, EventArgs e) { Calculate(); }
        private void BtDelete_Click(object ob, EventArgs e) { InputDelete(); }
        private void BtClear_Click(object ob, EventArgs e) { EvalSet(string.Empty); InputSet(string.Empty); SymbolSet(">"); }
        private void BtCopy_Click(object ob, EventArgs e) { InputAdd(lastResult); }
        private void BtCom_Click(object ob, EventArgs e) { InputAdd(SymbolComma); }
        private void BtFactorial_Click(object ob, EventArgs e) { InputAdd("!"); }
        private void BtReciprocal_Click(object ob, EventArgs e) { InputAddLeft("1/"); }
        private void BtPow_Click(object ob, EventArgs e) { InputAdd("^"); }
        private void BtOperatorRight_Click(object ob, EventArgs e) { Button bt = (Button)ob; InputAdd(bt.Text); }
        private void BtOperatorLeft_Click(object ob, EventArgs e) { Button bt = (Button)ob; InputAddLeft(bt.Text); }
        private void BtNegate_Click(object ob, EventArgs e) { SymbolSet(">"); InputSet(InputGet().Length >= 1 && InputGet()[0] == '-' ? InputGet().Substring(1) : '-' + InputGet()); } //Negate the current input
        private void BtNumeric_Click(object ob, EventArgs e) { Button bt = (Button)ob; InputAdd(bt.Name.Substring(2, 1)); }
        private void TxtBox_SizeTextChanged(object ob, EventArgs e) { Utility.ObjectResizeContents(ob); } //TextBox Autoresize Contents
        private void Label_SizeTextChanged(object ob, EventArgs e) { Utility.ObjectResizeContents(ob); } //TextBox Autoresize Contents
        private void Object_Changed(object ob, EventArgs e) { Utility.ObjectResizeContents(ob); } //Button Autoresize Contents
        private void ObjectHelper_Changed(object ob, EventArgs e) { Utility.ButtonResizeHelper(ob, Bt0); } //Buttons Autoresize Helper
        private void BtBase_Click(object ob, EventArgs e) { Button bt = (Button)ob; Clipboard.SetText(bt.Text); } //Copy Converted Bases
        private void TbDeselect_Enter(object sender, EventArgs e) { this.ActiveControl = null; }
    }
    internal static class Utility {
        internal static bool IsNumeric(string value) { return Regex.IsMatch(value, @"^[0-9A-F]+$", RegexOptions.IgnoreCase); }
        internal static Color ColorInvert(Color color) { return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B); }
        internal static Color ColorOffset(Color col, int off, bool negative) { return negative ? Color.FromArgb(col.A - off, col.R - off, col.B - off) : Color.FromArgb(col.A + off, col.R + off, col.B + off); }
        internal static string updateResponse = "";
        internal static bool UpdateCheck(string URL, string currentVersion) {
            UpdateCheckAsync(URL);
            string availableVersion = "0.0.0";
            string versionPattern = @"const\s+string\s+ProjectVersion\s+=\s+""(?<version>\d+(\.\d+){0,2})"";";
            Match match = Regex.Match(updateResponse, versionPattern);
            if (match.Success) availableVersion = match.Groups["version"].Value;
            return (currentVersion == availableVersion);
        }
        internal async static void UpdateCheckAsync(string URL) {
            string responseBody = "";
            try {
                HttpClient client = new HttpClient();
                using HttpResponseMessage response = await client.GetAsync(URL);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            } catch { }
            updateResponse = responseBody;
        }
        internal static IEnumerable<Control> GetAllElements(this Control control) {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(GetAllElements).Concat(controls);
        }
        internal static void ObjectResizeContents(object sender) {
            Control? control = sender as Control;
            double multiplier = sender switch {
                Button => 0.6,
                Label => 0.95,
                RichTextBox => 1.0,
                _ => 1.0
            };
            if (control!.Text.Length > 0) {
                using (Graphics g = control.CreateGraphics()) {
                    float maxFontSize = float.MaxValue; // Maximum font size
                    SizeF textSize = g.MeasureString(control.Text, control.Font);
                    if (textSize.Width <= 0 || textSize.Height <= 0) return; // Ensure that the width and height ratios are greater than 0
                    float widthRatio = control.Width / textSize.Width;
                    float heightRatio = control.Height / textSize.Height;
                    float ratio = (int)(control.Font.Size * (Math.Min(widthRatio, heightRatio) * multiplier)); // Calculate the desired font size
                    ratio = Math.Max(1, Math.Min(ratio, maxFontSize)); // Ensure that the calculated font size is within a valid range
                    control.Font = new Font(control.Font.FontFamily, ratio, control.Font.Style);
                }
            }
        }
        internal static void ButtonResizeHelper(object sender, Button bt) {
            Button button = (Button)sender;
            button.Font = new Font(bt.Font.FontFamily, bt.Font.Size, bt.Font.Style);
        }
        [DllImport("dwmapi.dll")] // Used for the following titlebar recoloring
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        internal static bool UseImmersiveDarkMode(IntPtr handle, bool enabled) {
            if (IsWindows10OrGreater(17763)) {
                var attribute = 19; //DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1
                if (IsWindows10OrGreater(18985)) attribute = 20; //DWMWA_USE_IMMERSIVE_DARK_MODE
                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }
            return false;
        }
        private static bool IsWindows10OrGreater(int build = -1) { return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build; }
    }
    internal partial class Evaluation {
        internal string Sanitize(string eval, int baseCurrent) {
            string[] elements = Regex.Split(eval.Trim(), @"^[\dA-F]+$"); //Split by Numeric & Non-Numeric parts
            for (int i = 0; i < elements.Length; i++) if (Utility.IsNumeric(elements[i])) elements[i] = Converter.ConvertBase(elements[i], baseCurrent, 10);
            eval = string.Join("", elements);
            eval = eval.Replace('x', '*').Replace(',', '.').Replace('[', '(').Replace('{', '(').Replace(']', ')').Replace('}', ')');
            eval = Regex.Replace(eval, @"(?<=[\dA-F()√π])[\(√π]", "*$0"); // Insert missing multiplier operators
            eval = eval.Replace("π", "PI()"); //Sanitize
            eval = Regex.Replace(eval, @"(\d+|[0-9A-F]+)!+", match => { // Handle Factorials
                string innerMatch = match.Groups[1].Value;
                int numberOfExclamationMarks = match.Value.Count(c => c == '!');
                for (int i = 0; i < numberOfExclamationMarks; i++) innerMatch = $"FACT({innerMatch})";
                return innerMatch;
            });
            eval = Regex.Replace(eval, @"√+([0-9A-F]+)", match => { // Handle Square Roots
                string innerMatch = match.Groups[1].Value;
                int numberOfSquareRoots = match.Value.Count(c => c == '√');
                innerMatch = $"SQRT({innerMatch})"; //'√' is a leading symbol
                for (int i = 1; i < numberOfSquareRoots; i++) innerMatch = $"SQRT({innerMatch})";
                return innerMatch;
            });
            return eval;
        }
    }
    internal class Converter {
        private static readonly Dictionary<char, int> CharToInt = new Dictionary<char, int> { { '0', 0 }, { '1', 1 }, { '2', 2 }, { '3', 3 }, { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 }, { '8', 8 }, { '9', 9 }, { 'A', 10 }, { 'B', 11 }, { 'C', 12 }, { 'D', 13 }, { 'E', 14 }, { 'F', 15 } };
        private static readonly Dictionary<int, char> IntToChar = new Dictionary<int, char> { { 0, '0' }, { 1, '1' }, { 2, '2' }, { 3, '3' }, { 4, '4' }, { 5, '5' }, { 6, '6' }, { 7, '7' }, { 8, '8' }, { 9, '9' }, { 10, 'A' }, { 11, 'B' }, { 12, 'C' }, { 13, 'D' }, { 14, 'E' }, { 15, 'F' } };
        internal static string ConvertBase(string input, int fromBase, int toBase) {
            input = input.ToUpper();
            BigInteger value = 0;
            for (int i = input.Length - 1; i >= 0; i--) value += CharToInt[input[i]] * BigInteger.Pow(fromBase, input.Length - 1 - i); // Convert input to decimal (base 10)
            StringBuilder result = new StringBuilder();
            while (value > 0) { // Convert decimal to the desired base
                result.Insert(0, IntToChar[(int)(value % toBase)]);
                value /= toBase;
            }
            return result.Length > 0 ? result.ToString() : "0";
        }
    }
}