using Microsoft.Win32;
using System.Data;

namespace Calculator
{
    public partial class Calculator : Form
    {
        DataTable dt = new DataTable();
        private void funCalc()
        {
            try { btOutput.Text = dt.Compute(txtInput.Text, "").ToString(); }
            catch (Exception ex) { btOutput.Text = ex.Message; }
            if (btOutput.Text != string.Empty) Clipboard.SetText(btOutput.Text);
        }
        private void funColorToggle()
        {
            //Titlebar
            //Menustrip
            aboutToolStripMenuItem.BackColor = ColorExtension.funInvert(aboutToolStripMenuItem.BackColor);
            aboutToolStripMenuItem.ForeColor = ColorExtension.funInvert(aboutToolStripMenuItem.ForeColor);
            foreach (Control item in this.Controls)
            {
                item.BackColor = ColorExtension.funInvert(item.BackColor);
                item.ForeColor = ColorExtension.funInvert(item.ForeColor);
            }
        }
        public Calculator()
        {
            InitializeComponent();
            if ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == 0) { funColorToggle(); MenuDarkmode.Checked = true; }
            this.ActiveControl = txtInput;
            this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
            txtInput.KeyDown += new KeyEventHandler(txtInput_KeyDown);
            //add all to table layout, merge input/output
            //hover background color
            //3d button effect top left > center
        }
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { funCalc(); e.Handled = e.SuppressKeyPress = true; }
        }
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) funCalc();
            else txtInput.Text += e.KeyChar;
        }
        private void btCalc_Click(object sender, EventArgs e) { funCalc(); }
        private void btClear_Click(object sender, EventArgs e) { txtInput.Text = btOutput.Text = string.Empty; }
        private void btDelete_Click(object sender, EventArgs e) { txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1); }
        private void btAdd_Click(object sender, EventArgs e) { txtInput.Text += "+"; }
        private void btSub_Click(object sender, EventArgs e) { txtInput.Text += "-"; }
        private void btMul_Click(object sender, EventArgs e) { txtInput.Text += "*"; }
        private void btDiv_Click(object sender, EventArgs e) { txtInput.Text += "/"; }
        private void btCom_Click(object sender, EventArgs e) { txtInput.Text += "."; }
        private void bt0_Click(object sender, EventArgs e) { txtInput.Text += "0"; }
        private void bt1_Click(object sender, EventArgs e) { txtInput.Text += "1"; }
        private void bt2_Click(object sender, EventArgs e) { txtInput.Text += "2"; }
        private void bt3_Click(object sender, EventArgs e) { txtInput.Text += "3"; }
        private void bt4_Click(object sender, EventArgs e) { txtInput.Text += "4"; }
        private void bt5_Click(object sender, EventArgs e) { txtInput.Text += "5"; }
        private void bt6_Click(object sender, EventArgs e) { txtInput.Text += "6"; }
        private void bt7_Click(object sender, EventArgs e) { txtInput.Text += "7"; }
        private void bt8_Click(object sender, EventArgs e) { txtInput.Text += "8"; }
        private void bt9_Click(object sender, EventArgs e) { txtInput.Text += "9"; }
        private void MenuTopMost_Click(object sender, EventArgs e)
        {
            if (MenuTopMost.Checked == true) { this.TopMost = false; MenuTopMost.Checked = false; }
            else { this.TopMost = true; MenuTopMost.Checked = true; }
        }
        private void MenuDarkmode_Click(object sender, EventArgs e)
        {
            if (MenuDarkmode.Checked == true) { MenuDarkmode.Checked = false; funColorToggle(); }
            else { MenuDarkmode.Checked = true; funColorToggle(); }
        }
        private void MenuInfo_Click(object sender, EventArgs e) { MessageBox.Show("Sample Calculator", "Info"); }
    }
    public static class ColorExtension
    {
        public static Color funInvert(this Color color)
        {
            return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
        }
    }
}