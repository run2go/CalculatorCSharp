using Microsoft.Win32; //Registry checks (Used to get system theme)
using org.matheval; //Solve math equations
using System.Diagnostics; //Access explorer.exe to open URLs in default browser
using System.Globalization; //Get System Localization, grab default Comma character

namespace Calculator
{
    public partial class Calculator : Form
    {
        string[] textLines = new string[2];
        string projectWebsite = "https://github.com/run2go/Calculator";
        public Calculator()
        {
            InitializeComponent();
            if ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1)! == 0) ColorToggle(MenuEditDarkmode.Checked, this);
            btCom.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            ActiveControl = txtCalc;
            txtCalc.KeyDown += new KeyEventHandler(txtCalc_KeyDown!);
        }
        private void Calc()
        {
            try
            {
                TextSplit();
                Expression calc = new Expression(textLines[0].Replace(',', '.'));
                textLines[1] = (textLines[0] != string.Empty) ? calc.Eval().ToString()! : "♥";
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
            if (textLines[1] != string.Empty) txtCalc.Text = $"{textLines[0]}{Environment.NewLine}= {textLines[1]}";
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
                if (textLines.Length > 1)
                {
                    TextSplit();
                    textLines[0] = textLines[0].Substring(0, textLines[0].Length - 1);
                    if (textLines.Length >= 1) textLines[1] = string.Empty;
                }
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
        private void ColorToggle(bool boolDarkmode, Control parentControl)
        {
            MenuEditDarkmode.Checked = !boolDarkmode; //Toggle DM Checkbox
            foreach (Control item in this.GetAllElements())
            {
                Button? btn = item as Button;
                if (btn != null) btn.FlatAppearance.BorderColor = Utility.InvertColor(btn.FlatAppearance.BorderColor);
                item.BackColor = Utility.InvertColor(item.BackColor);
                item.ForeColor = Utility.InvertColor(item.ForeColor);
            }
        }
        private static List<Control> FindAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            FindAllControls(container, controlList);
            return controlList;
        }
        private static void FindAllControls(Control container, List<Control> ctrlList)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl.Controls.Count == 0) ctrlList.Add(ctrl);
                else FindAllControls(ctrl, ctrlList);
            }
        }
        private void HandleError(Exception ex) { if (MenuModeDebug.Checked) MessageBox.Show(ex.ToString(), "Error"); }
        private void txtCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Calc(); e.Handled = e.SuppressKeyPress = true; }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C) Clipboard.SetText(textLines[1]);
        }
        private void MenuTopMost_Click(object sender, EventArgs e) { this.TopMost = MenuEditTopmost.Checked = !MenuEditTopmost.Checked; }
        private void MenuDarkmode_Click(object sender, EventArgs e) { ColorToggle(MenuEditDarkmode.Checked, this); }
        private void StripMenuAbout_Click(object sender, EventArgs e) { Process.Start("explorer.exe", projectWebsite); }
        private void MenuViewSimple_Click(object sender, EventArgs e)
        {
            MenuModeSimple.Checked = true;
            MenuModeAdvanced.Checked = false;
            TextReplace("Simple Mode");
        }
        private void MenuViewAdvanced_Click(object sender, EventArgs e)
        {
            MenuModeSimple.Checked = false;
            MenuModeAdvanced.Checked = true;
            TextReplace("Advanced Mode");
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
}