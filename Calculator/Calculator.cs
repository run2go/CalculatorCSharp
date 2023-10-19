using Microsoft.Win32; //Registry checks (Used to get system theme)
using System.Diagnostics; //Access explorer.exe to open URLs in default browser
using System.Globalization; //Get System Localization, grab default Comma character
using System.Text; //Used by StringBuilder, required by MathExtension
namespace Calculator
{
    public partial class Interface : Form
    {
        string[] textLines = new string[2];
        string projectWebsite = "https://github.com/run2go/Calculator";
        public Interface()
        {
            InitializeComponent();
            if ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1)! == 0) ColorToggle(MenuEditDarkmode.Checked);
            ActiveControl = txtCalc;
            btCom.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            txtCalc.KeyDown += new KeyEventHandler(txtCalc_KeyDown!);
        }
        private void Calc()
        {
            try
            {
                TextSplit();
                MathExtension math = new MathExtension();
                textLines[1] = (textLines[0] != string.Empty) ? math.Eval(textLines[0].Replace(',', '.')).ToString()! : "♥";
            }
            catch (Exception ex) { textLines[1] = "Invalid Input"; TextUpdate(); HandleError(ex); }
            TextUpdate();
        }
        private void TextFocus()
        {
            if (txtCalc.Text.Length > 0)
            {
                txtCalc.SelectionStart = txtCalc.Lines[0].Length;
                txtCalc.SelectionLength = 0;
            }
            txtCalc.Focus();
        }
        private void TextSplit()
        {
            textLines = txtCalc.Text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            if (textLines.Length == 1) textLines = new string[] { textLines[0], string.Empty };
        }
        private void TextUpdate()
        {
            if (textLines[1].Length > 0 && textLines[0].Length != 0) txtCalc.Text = $"{textLines[0]}{Environment.NewLine}= {textLines[1]}";
            else txtCalc.Text = $"{textLines[0]}";
            txtCalc.Select(textLines[0].Length + 2, textLines[1].Length);
            txtCalc.SelectionLength = textLines[1].Length * 3;
            txtCalc.SelectionFont = new Font(txtCalc.Font, FontStyle.Bold);
            TextFocus();
        }
        private void TextAppend(string textAppend)
        {
            TextSplit();
            textLines[0] += textAppend;
            textLines[1] = string.Empty;
            TextUpdate();
        }
        private void TextDelete()
        {
            try
            {
                TextSplit();
                textLines[0] = textLines[0].Substring(0, textLines[0].Length - 1);
                textLines[1] = string.Empty;
            }
            catch (Exception ex) { HandleError(ex); }
            TextUpdate();
        }
        private void TextClear()
        {
            txtCalc.Clear();
            Array.Clear(textLines);
            TextFocus();
        }
        private void TextReplace(string message)
        {
            TextClear();
            TextAppend(Environment.NewLine + message);
            TextUpdate();
        }
        private void ColorToggle(bool boolDarkmode)
        {
            MenuEditDarkmode.Checked = !boolDarkmode; //Toggle DM Checkbox
            foreach (Control item in this.GetAllElements())
            {
                Button? button = item as Button;
                if (button != null) button.FlatAppearance.BorderColor = Utility.InvertColor(button.FlatAppearance.BorderColor);
                item.BackColor = Utility.InvertColor(item.BackColor);
                item.ForeColor = Utility.InvertColor(item.ForeColor);
            }
        }
        public void HandleError(Exception ex) { if (MenuModeDebug.Checked) MessageBox.Show(ex.ToString(), $"Debug: {ex.GetType()}"); }
        private void txtCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Calc(); e.Handled = e.SuppressKeyPress = true; }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C) Clipboard.SetText(textLines[1]);
        }
        private void MenuTopMost_Click(object sender, EventArgs e) { TopMost = MenuEditTopmost.Checked = !MenuEditTopmost.Checked; }
        private void MenuDarkmode_Click(object sender, EventArgs e) { ColorToggle(MenuEditDarkmode.Checked); }
        private void StripMenuAbout_Click(object sender, EventArgs e) { Process.Start("explorer.exe", projectWebsite); }
        private void MenuViewSimple_Click(object sender, EventArgs e)
        {
            if (!MenuModeSimple.Checked)
            {
                MenuModeSimple.Checked = true;
                MenuModeAdvanced.Checked = false;
                TextReplace("Simple Mode");
                int totalColumns = 6;
                for (int i = 0; i < totalColumns; i++) { tableLayoutButtons.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, 25); }
                for (int i = 4; i < totalColumns; i++) { tableLayoutButtons.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, 0); }
                Size = new Size(Size.Width / 15 * 10, Size.Height); //(180, 335)
            }
        }
        private void MenuViewAdvanced_Click(object sender, EventArgs e)
        {
            if (!MenuModeAdvanced.Checked)
            {
                MenuModeSimple.Checked = false;
                MenuModeAdvanced.Checked = true;
                TextReplace("Advanced Mode");
                int totalColumns = 6;
                float columnPercentage = 100f / totalColumns;
                for (int i = 0; i < totalColumns; i++) { tableLayoutButtons.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, columnPercentage); }
                Size = new Size(Size.Width * 15 / 10, Size.Height); //(270, 335)
            }
        }
        private void MenuViewDebug_Click(object sender, EventArgs e)
        {
            MenuModeDebug.Checked = !MenuModeDebug.Checked;
            if (MenuModeDebug.Checked) TextReplace("Debug Enabled");
            else TextReplace("Debug Disabled");
        }
        private void btCalc_Click(object sender, EventArgs e) { Calc(); }
        private void btClear_Click(object sender, EventArgs e) { TextClear(); }
        private void btDelete_Click(object sender, EventArgs e) { TextDelete(); }
        private void btCopy_Click(object sender, EventArgs e) { Clipboard.SetText(textLines[1]); }
        private void btAdd_Click(object sender, EventArgs e) { TextAppend("+"); }
        private void btSub_Click(object sender, EventArgs e) { TextAppend("-"); }
        private void btMul_Click(object sender, EventArgs e) { TextAppend("*"); }
        private void btDiv_Click(object sender, EventArgs e) { TextAppend("/"); }
        private void btCom_Click(object sender, EventArgs e) { TextAppend("."); }
        private void bt0_Click(object sender, EventArgs e) { TextAppend("0"); }
        private void bt1_Click(object sender, EventArgs e) { TextAppend("1"); }
        private void bt2_Click(object sender, EventArgs e) { TextAppend("2"); }
        private void bt3_Click(object sender, EventArgs e) { TextAppend("3"); }
        private void bt4_Click(object sender, EventArgs e) { TextAppend("4"); }
        private void bt5_Click(object sender, EventArgs e) { TextAppend("5"); }
        private void bt6_Click(object sender, EventArgs e) { TextAppend("6"); }
        private void bt7_Click(object sender, EventArgs e) { TextAppend("7"); }
        private void bt8_Click(object sender, EventArgs e) { TextAppend("8"); }
        private void bt9_Click(object sender, EventArgs e) { TextAppend("9"); }
        private void btPercent_Click(object sender, EventArgs e) { }
        private void btSqrt2_Click(object sender, EventArgs e) { }
        private void btSqrt3_Click(object sender, EventArgs e) { }
        private void btSqrt4_Click(object sender, EventArgs e) { }
        private void btNegate_Click(object sender, EventArgs e) { }
        private void btBinary_Click(object sender, EventArgs e) { }
        private void btHex_Click(object sender, EventArgs e) { }
        private void btDecimal_Click(object sender, EventArgs e) { }
    }
    public static class Utility
    {
        public static Color InvertColor(this Color color) { return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B); }
        public static IEnumerable<Control> GetAllElements(this Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllElements(ctrl)).Concat(controls);
        }
    }
    public partial class MathExtension
    {
        public class EquationElement
        {
            public enum ElementType { Number, Operator, OpenBracket, CloseBracket }
            public ElementType Type { get; set; }
            public string Value { get; set; }
            public EquationElement(ElementType type, string value)
            {
                Type = type;
                Value = value;
            }
        }
        public double Eval(string stEquation)
        {
            List<EquationElement> equationElements = ParseEquation(stEquation);
            Stack<double> numbers = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            foreach (var element in equationElements)
            {
                if (element.Type == EquationElement.ElementType.Number) numbers.Push(double.Parse(element.Value));
                else if (element.Type == EquationElement.ElementType.Operator) operators.Push(element.Value[0]);
                else if (element.Type == EquationElement.ElementType.OpenBracket) operators.Push('(');
                else if (element.Type == EquationElement.ElementType.CloseBracket)
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        PerformOperation(numbers, operators);
                    }
                    operators.Pop(); // Pop the '('
                }
            }
            while (operators.Count > 0)
            {
                PerformOperation(numbers, operators);
            }
            return numbers.Pop();
        }
        private void PerformOperation(Stack<double> numbers, Stack<char> operators)
        {
            double num2 = numbers.Pop();
            double num1 = numbers.Pop();
            char op = operators.Pop();
            double result = 0;
            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num1 / num2; break;
            }
            numbers.Push(result);
        }
        private List<EquationElement> ParseEquation(string stEquation)
        {
            List<EquationElement> equationElements = new List<EquationElement>();
            StringBuilder currentElement = new StringBuilder();
            bool decimalEncountered = false; // Flag to track if decimal point has been encountered
            foreach (char character in stEquation)
            {
                if (char.IsDigit(character) || (character == Convert.ToChar('.') && !decimalEncountered))
                {
                    if (character == '.') decimalEncountered = true; // Set the flag if a decimal point is encountered
                    currentElement.Append(character);
                }
                else if (IsOperator(character))
                {
                    if (currentElement.Length > 0) // If the current element is not empty, add it to the list
                    {
                        equationElements.Add(new EquationElement(EquationElement.ElementType.Number, currentElement.ToString()));
                        currentElement.Clear(); // Clear the StringBuilder for the next element
                    }
                    equationElements.Add(new EquationElement(EquationElement.ElementType.Operator, character.ToString())); // Add the operator to the list
                }
                else if (character == '(')
                {
                    if (currentElement.Length > 0) // If the current element is not empty, add it to the list
                    {
                        equationElements.Add(new EquationElement(EquationElement.ElementType.Number, currentElement.ToString()));
                        currentElement.Clear(); // Clear the StringBuilder for the next element
                    }
                    equationElements.Add(new EquationElement(EquationElement.ElementType.OpenBracket, character.ToString())); // Add the open bracket to the list
                }
                else if (character == ')')
                {
                    if (currentElement.Length > 0) // If the current element is not empty, add it to the list
                    {
                        equationElements.Add(new EquationElement(EquationElement.ElementType.Number, currentElement.ToString()));
                        currentElement.Clear(); // Clear the StringBuilder for the next element
                    }
                    equationElements.Add(new EquationElement(EquationElement.ElementType.CloseBracket, character.ToString())); // Add the close bracket to the list
                }
                else if (!char.IsWhiteSpace(character)) throw new InvalidOperationException($"Invalid character '{character}' in the equation."); // Invalid character, throw an exception or handle it according to your requirements.
                decimalEncountered = false; // Reset the decimal flag for the next number
            }
            if (currentElement.Length > 0) equationElements.Add(new EquationElement(EquationElement.ElementType.Number, currentElement.ToString())); // If there's a remaining element in the StringBuilder, add it to the list
            return equationElements;
        }
        private bool IsOperator(char character) { return character == '+' || character == '-' || character == '*' || character == '/'; }
    }
}