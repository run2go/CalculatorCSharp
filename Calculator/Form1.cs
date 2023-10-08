using System.Data;

namespace Calculator
{
    public partial class Calculator : Form
    {
        DataTable dt = new DataTable();
        private double funCalc(string input) { return Convert.ToDouble(dt.Compute(input, "")); }
        public Calculator()
        {
            InitializeComponent();
            this.ActiveControl = txtInput;
            txtInput.KeyDown += new KeyEventHandler(txtInput_KeyDown);
        }
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try { btOutput.Text = funCalc(txtInput.Text).ToString(); }
                catch (Exception ex) { btOutput.Text = ex.Message; }
                e.Handled = true;
                e.SuppressKeyPress = true;
                Clipboard.SetText(btOutput.Text);
            }
        }
        private void btCalc_Click(object sender, EventArgs e)
        {
            try { btOutput.Text = funCalc(txtInput.Text).ToString(); }
            catch (Exception ex) { btOutput.Text = ex.Message; }
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            btOutput.Text = string.Empty;
        }

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
    }
}