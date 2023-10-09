namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
            txtInput = new TextBox();
            bt9 = new Button();
            btDelete = new Button();
            bt0 = new Button();
            bt6 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt5 = new Button();
            btAdd = new Button();
            bt8 = new Button();
            btDiv = new Button();
            btCom = new Button();
            btClear = new Button();
            bt1 = new Button();
            btMul = new Button();
            bt4 = new Button();
            bt7 = new Button();
            btCalc = new Button();
            btSub = new Button();
            btOutput = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(164, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, toolStripSeparator1, alwaysOnTopToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(150, 22);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(147, 6);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.Checked = true;
            alwaysOnTopToolStripMenuItem.CheckState = CheckState.Checked;
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new Size(150, 22);
            alwaysOnTopToolStripMenuItem.Text = "Always on Top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // txtInput
            // 
            txtInput.Dock = DockStyle.Top;
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(0, 24);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(164, 29);
            txtInput.TabIndex = 2;
            // 
            // bt9
            // 
            bt9.Anchor = AnchorStyles.None;
            bt9.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt9.Location = new Point(85, 45);
            bt9.Name = "bt9";
            bt9.Size = new Size(34, 33);
            bt9.TabIndex = 3;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // btDelete
            // 
            btDelete.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(btDelete, 2);
            btDelete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btDelete.ForeColor = SystemColors.WindowFrame;
            btDelete.Location = new Point(3, 4);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 33);
            btDelete.TabIndex = 3;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // bt0
            // 
            bt0.Anchor = AnchorStyles.None;
            bt0.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt0.Location = new Point(44, 168);
            bt0.Name = "bt0";
            bt0.Size = new Size(34, 33);
            bt0.TabIndex = 3;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt6
            // 
            bt6.Anchor = AnchorStyles.None;
            bt6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt6.Location = new Point(85, 86);
            bt6.Name = "bt6";
            bt6.Size = new Size(34, 33);
            bt6.TabIndex = 3;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += bt6_Click;
            // 
            // bt2
            // 
            bt2.Anchor = AnchorStyles.None;
            bt2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt2.Location = new Point(44, 127);
            bt2.Name = "bt2";
            bt2.Size = new Size(34, 33);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Anchor = AnchorStyles.None;
            bt3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt3.Location = new Point(85, 127);
            bt3.Name = "bt3";
            bt3.Size = new Size(34, 33);
            bt3.TabIndex = 3;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt5
            // 
            bt5.Anchor = AnchorStyles.None;
            bt5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt5.Location = new Point(44, 86);
            bt5.Name = "bt5";
            bt5.Size = new Size(34, 33);
            bt5.TabIndex = 3;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // btAdd
            // 
            btAdd.Anchor = AnchorStyles.None;
            btAdd.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btAdd.ForeColor = SystemColors.WindowFrame;
            btAdd.Location = new Point(126, 168);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(34, 33);
            btAdd.TabIndex = 3;
            btAdd.Text = "+";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // bt8
            // 
            bt8.Anchor = AnchorStyles.None;
            bt8.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt8.Location = new Point(44, 45);
            bt8.Name = "bt8";
            bt8.Size = new Size(34, 33);
            bt8.TabIndex = 3;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += bt8_Click;
            // 
            // btDiv
            // 
            btDiv.Anchor = AnchorStyles.None;
            btDiv.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btDiv.ForeColor = SystemColors.WindowFrame;
            btDiv.Location = new Point(126, 45);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(34, 33);
            btDiv.TabIndex = 3;
            btDiv.Text = "/";
            btDiv.UseVisualStyleBackColor = false;
            btDiv.Click += btDiv_Click;
            // 
            // btCom
            // 
            btCom.Anchor = AnchorStyles.None;
            btCom.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCom.ForeColor = SystemColors.WindowFrame;
            btCom.Location = new Point(3, 168);
            btCom.Name = "btCom";
            btCom.Size = new Size(34, 33);
            btCom.TabIndex = 3;
            btCom.Text = ".";
            btCom.UseVisualStyleBackColor = false;
            btCom.Click += btCom_Click;
            // 
            // btClear
            // 
            btClear.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(btClear, 2);
            btClear.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btClear.ForeColor = SystemColors.WindowFrame;
            btClear.Location = new Point(85, 4);
            btClear.Name = "btClear";
            btClear.Size = new Size(75, 33);
            btClear.TabIndex = 3;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // bt1
            // 
            bt1.Anchor = AnchorStyles.None;
            bt1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(3, 127);
            bt1.Name = "bt1";
            bt1.Size = new Size(34, 33);
            bt1.TabIndex = 3;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // btMul
            // 
            btMul.Anchor = AnchorStyles.None;
            btMul.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btMul.ForeColor = SystemColors.WindowFrame;
            btMul.Location = new Point(126, 86);
            btMul.Name = "btMul";
            btMul.Size = new Size(34, 33);
            btMul.TabIndex = 3;
            btMul.Text = "x";
            btMul.UseVisualStyleBackColor = false;
            btMul.Click += btMul_Click;
            // 
            // bt4
            // 
            bt4.Anchor = AnchorStyles.None;
            bt4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt4.Location = new Point(3, 86);
            bt4.Name = "bt4";
            bt4.Size = new Size(34, 33);
            bt4.TabIndex = 3;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // bt7
            // 
            bt7.Anchor = AnchorStyles.None;
            bt7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt7.Location = new Point(3, 45);
            bt7.Name = "bt7";
            bt7.Size = new Size(34, 33);
            bt7.TabIndex = 3;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // btCalc
            // 
            btCalc.Anchor = AnchorStyles.None;
            btCalc.BackColor = SystemColors.ActiveCaption;
            btCalc.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCalc.ForeColor = SystemColors.ControlLightLight;
            btCalc.Location = new Point(85, 168);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(34, 33);
            btCalc.TabIndex = 3;
            btCalc.Text = "=";
            btCalc.UseVisualStyleBackColor = false;
            btCalc.Click += btCalc_Click;
            // 
            // btSub
            // 
            btSub.Anchor = AnchorStyles.None;
            btSub.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSub.ForeColor = SystemColors.WindowFrame;
            btSub.Location = new Point(126, 127);
            btSub.Name = "btSub";
            btSub.Size = new Size(34, 33);
            btSub.TabIndex = 3;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = false;
            btSub.Click += btSub_Click;
            // 
            // btOutput
            // 
            btOutput.Dock = DockStyle.Top;
            btOutput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btOutput.Location = new Point(0, 53);
            btOutput.Name = "btOutput";
            btOutput.Size = new Size(164, 37);
            btOutput.TabIndex = 4;
            btOutput.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(bt7, 0, 1);
            tableLayoutPanel1.Controls.Add(bt4, 0, 2);
            tableLayoutPanel1.Controls.Add(btClear, 2, 0);
            tableLayoutPanel1.Controls.Add(btMul, 3, 2);
            tableLayoutPanel1.Controls.Add(btDelete, 0, 0);
            tableLayoutPanel1.Controls.Add(btDiv, 3, 1);
            tableLayoutPanel1.Controls.Add(btSub, 3, 3);
            tableLayoutPanel1.Controls.Add(btCalc, 2, 4);
            tableLayoutPanel1.Controls.Add(bt1, 0, 3);
            tableLayoutPanel1.Controls.Add(bt6, 2, 2);
            tableLayoutPanel1.Controls.Add(btCom, 0, 4);
            tableLayoutPanel1.Controls.Add(bt0, 1, 4);
            tableLayoutPanel1.Controls.Add(bt9, 2, 1);
            tableLayoutPanel1.Controls.Add(bt3, 2, 3);
            tableLayoutPanel1.Controls.Add(bt8, 1, 1);
            tableLayoutPanel1.Controls.Add(bt5, 1, 2);
            tableLayoutPanel1.Controls.Add(btAdd, 3, 4);
            tableLayoutPanel1.Controls.Add(bt2, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(164, 206);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // Calculator
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(164, 296);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btOutput);
            Controls.Add(txtInput);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(180, 335);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            TopMost = true;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox txtInput;
        private Button bt9;
        private Button btDelete;
        private Button bt0;
        private Button bt6;
        private Button bt2;
        private Button bt3;
        private Button bt5;
        private Button btAdd;
        private Button bt8;
        private Button btDiv;
        private Button btCom;
        private Button btClear;
        private Button bt1;
        private Button btMul;
        private Button bt4;
        private Button bt7;
        private Button btCalc;
        private Button btSub;
        private Button btOutput;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
    }
}