using Microsoft.Win32;
using System.Data;
namespace Calculator
{
    public partial class Calculator : Form
    {
        DataTable dt = new DataTable();
        string[] textLines = new string[2];
        private void Calc()
        {
            try
            {
                TextSplit();
                textLines[1] = (textLines[0] != string.Empty) ? dt.Compute(textLines[0], "").ToString() : "♥";
                TextUpdate();
                Clipboard.SetText(textLines[1]);
                txtCalc.SelectionStart = txtCalc.Lines[0].Length;
                txtCalc.SelectionLength = 0;
                txtCalc.Focus();
            }
            catch (Exception ex) { textLines[1] = "Invalid Operator"; TextUpdate(); HandleError(ex); }
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
        }
        private void TextAppend(string textAppend)
        {
            textLines[0] += textAppend;
            textLines[1] = string.Empty;
            TextUpdate();
        }
        private void TextDelete()
        {
            if (textLines[0] != string.Empty)
            {
                try
                {
                    TextSplit();
                    textLines[0] = textLines[0].Substring(0, textLines[0].Length - 1);
                    textLines[1] = string.Empty;
                    TextUpdate();
                }
                catch (Exception ex) { HandleError(ex); }
            }
        }
        int temp = 0;
        private void ColorToggle(bool parentCheck, Control parentControl)
        {
            if (parentCheck)
            {
                parentControl.BackColor = ColorEx.Invert(parentControl.BackColor);
                parentControl.ForeColor = ColorEx.Invert(parentControl.ForeColor);
            }
            Button button = parentControl as Button;
            if (button != null) button.FlatAppearance.BorderColor = ColorEx.Invert(button.FlatAppearance.BorderColor);
            foreach (Control childControl in parentControl.Controls)
            {
                ColorToggle(false, childControl);
                temp++;
            }

            /*if (parentCheck)
            {
                Button button = parentControl as Button;
                if (button != null) button.FlatAppearance.BorderColor = ColorEx.Invert(button.FlatAppearance.BorderColor);
                foreach (Control childControl in parentControl.Controls)
                {
                    ColorToggle(true, childControl);
                    temp++;
                }
            }*/

            /*
            parentControl.BackColor = ColorEx.Invert(parentControl.BackColor);
            parentControl.ForeColor = ColorEx.Invert(parentControl.ForeColor);
    
            Button button = parentControl as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = ColorEx.Invert(button.FlatAppearance.BorderColor);
                // Invert border color for child controls of the button
                foreach (Control childControl in button.Controls)
                {
                    ColorToggle(false, childControl);
                }
            }

            if (parentCheck)
            {
                foreach (Control childControl in parentControl.Controls)
                {
                    ColorToggle(true, childControl);
                }
            }
            */
        }
        private void HandleError(Exception ex) { if (MenuViewDebug.Checked) MessageBox.Show(ex.ToString(), "Error"); }
        public Calculator()
        {
            InitializeComponent();
            if ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == 0) { MenuEditDarkmode.Checked = true; }
            if (MenuEditDarkmode.Checked) ColorToggle(true, this);
            this.ActiveControl = txtCalc;
            this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
            txtCalc.KeyDown += new KeyEventHandler(txtCalc_KeyDown);
        }
        private void txtCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Calc(); e.Handled = e.SuppressKeyPress = true; }
        }
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Calc();
            else txtCalc.Text += e.KeyChar;
        }
        private void MenuTopMost_Click(object sender, EventArgs e) { this.TopMost = MenuEditTopmost.Checked = !MenuEditTopmost.Checked; }
        private void MenuDarkmode_Click(object sender, EventArgs e) { MenuEditDarkmode.Checked = !MenuEditDarkmode.Checked; ColorToggle(true, this); }
        private void StripMenuAbout_Click(object sender, EventArgs e) { MessageBox.Show("Sample Calculator", "Info"); }
        private void MenuViewSimple_Click(object sender, EventArgs e)
        {
            MenuViewSimple.Checked = true;
            MenuViewAdvanced.Checked = false;
            MenuViewDebug.Checked = false;
            txtCalc.Text = Environment.NewLine + "Simple Mode";
        }
        private void MenuViewAdvanced_Click(object sender, EventArgs e)
        {
            MenuViewSimple.Checked = false;
            MenuViewAdvanced.Checked = true;
            MenuViewDebug.Checked = false;
            txtCalc.Text = Environment.NewLine + "Advanced Mode";
        }
        private void MenuViewDebug_Click(object sender, EventArgs e)
        {
            MenuViewSimple.Checked = false;
            MenuViewAdvanced.Checked = false;
            MenuViewDebug.Checked = true;
            txtCalc.Text = Environment.NewLine + "Debug Mode";
        }
        private void btCalc_Click(object sender, EventArgs e) { Calc(); }
        private void btClear_Click(object sender, EventArgs e) { txtCalc.Text = textLines[0] = textLines[1] = string.Empty; }
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
    public static class ColorEx
    {
        public static Color Invert(this Color color) { return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B); }
    }
}