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
            MenuTopMost = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuInfo = new ToolStripMenuItem();
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
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuTopMost, toolStripSeparator1, MenuInfo });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // MenuTopMost
            // 
            MenuTopMost.Checked = true;
            MenuTopMost.CheckState = CheckState.Checked;
            MenuTopMost.Name = "MenuTopMost";
            MenuTopMost.Size = new Size(150, 22);
            MenuTopMost.Text = "Always on Top";
            MenuTopMost.Click += MenuTopMost_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(147, 6);
            // 
            // MenuInfo
            // 
            MenuInfo.Name = "MenuInfo";
            MenuInfo.Size = new Size(150, 22);
            MenuInfo.Text = "Info";
            MenuInfo.Click += MenuInfo_Click;
            // 
            // txtInput
            // 
            txtInput.AllowDrop = true;
            txtInput.Cursor = Cursors.IBeam;
            txtInput.Dock = DockStyle.Top;
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(0, 24);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(164, 29);
            txtInput.TabIndex = 2;
            // 
            // bt9
            // 
            bt9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt9.AutoSize = true;
            bt9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt9.Cursor = Cursors.Hand;
            bt9.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt9.Location = new Point(85, 44);
            bt9.Name = "bt9";
            bt9.Size = new Size(35, 35);
            bt9.TabIndex = 3;
            bt9.TabStop = false;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // btDelete
            // 
            btDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btDelete.AutoSize = true;
            btDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(btDelete, 2);
            btDelete.Cursor = Cursors.Hand;
            btDelete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btDelete.ForeColor = SystemColors.WindowFrame;
            btDelete.Location = new Point(3, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(76, 35);
            btDelete.TabIndex = 3;
            btDelete.TabStop = false;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // bt0
            // 
            bt0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt0.AutoSize = true;
            bt0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt0.Cursor = Cursors.Hand;
            bt0.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt0.Location = new Point(44, 167);
            bt0.Name = "bt0";
            bt0.Size = new Size(35, 36);
            bt0.TabIndex = 3;
            bt0.TabStop = false;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt6
            // 
            bt6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt6.AutoSize = true;
            bt6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt6.Cursor = Cursors.Hand;
            bt6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt6.Location = new Point(85, 85);
            bt6.Name = "bt6";
            bt6.Size = new Size(35, 35);
            bt6.TabIndex = 3;
            bt6.TabStop = false;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += bt6_Click;
            // 
            // bt2
            // 
            bt2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt2.AutoSize = true;
            bt2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt2.Cursor = Cursors.Hand;
            bt2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt2.Location = new Point(44, 126);
            bt2.Name = "bt2";
            bt2.Size = new Size(35, 35);
            bt2.TabIndex = 3;
            bt2.TabStop = false;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt3.AutoSize = true;
            bt3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt3.Cursor = Cursors.Hand;
            bt3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt3.Location = new Point(85, 126);
            bt3.Name = "bt3";
            bt3.Size = new Size(35, 35);
            bt3.TabIndex = 3;
            bt3.TabStop = false;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt5
            // 
            bt5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt5.AutoSize = true;
            bt5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt5.Cursor = Cursors.Hand;
            bt5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt5.Location = new Point(44, 85);
            bt5.Name = "bt5";
            bt5.Size = new Size(35, 35);
            bt5.TabIndex = 3;
            bt5.TabStop = false;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // btAdd
            // 
            btAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAdd.AutoSize = true;
            btAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btAdd.Cursor = Cursors.Hand;
            btAdd.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btAdd.ForeColor = SystemColors.WindowFrame;
            btAdd.Location = new Point(126, 167);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(35, 36);
            btAdd.TabIndex = 3;
            btAdd.TabStop = false;
            btAdd.Text = "+";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // bt8
            // 
            bt8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt8.AutoSize = true;
            bt8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt8.Cursor = Cursors.Hand;
            bt8.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt8.Location = new Point(44, 44);
            bt8.Name = "bt8";
            bt8.Size = new Size(35, 35);
            bt8.TabIndex = 3;
            bt8.TabStop = false;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += bt8_Click;
            // 
            // btDiv
            // 
            btDiv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btDiv.AutoSize = true;
            btDiv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btDiv.Cursor = Cursors.Hand;
            btDiv.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btDiv.ForeColor = SystemColors.WindowFrame;
            btDiv.Location = new Point(126, 44);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(35, 35);
            btDiv.TabIndex = 3;
            btDiv.TabStop = false;
            btDiv.Text = "/";
            btDiv.UseVisualStyleBackColor = false;
            btDiv.Click += btDiv_Click;
            // 
            // btCom
            // 
            btCom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btCom.AutoSize = true;
            btCom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCom.Cursor = Cursors.Hand;
            btCom.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCom.ForeColor = SystemColors.WindowFrame;
            btCom.Location = new Point(3, 167);
            btCom.Name = "btCom";
            btCom.Size = new Size(35, 36);
            btCom.TabIndex = 3;
            btCom.TabStop = false;
            btCom.Text = ".";
            btCom.UseVisualStyleBackColor = false;
            btCom.Click += btCom_Click;
            // 
            // btClear
            // 
            btClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btClear.AutoSize = true;
            btClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(btClear, 2);
            btClear.Cursor = Cursors.Hand;
            btClear.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btClear.ForeColor = SystemColors.WindowFrame;
            btClear.Location = new Point(85, 3);
            btClear.Name = "btClear";
            btClear.Size = new Size(76, 35);
            btClear.TabIndex = 3;
            btClear.TabStop = false;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // bt1
            // 
            bt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt1.AutoSize = true;
            bt1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt1.Cursor = Cursors.Hand;
            bt1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(3, 126);
            bt1.Name = "bt1";
            bt1.Size = new Size(35, 35);
            bt1.TabIndex = 3;
            bt1.TabStop = false;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // btMul
            // 
            btMul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btMul.AutoSize = true;
            btMul.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btMul.Cursor = Cursors.Hand;
            btMul.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btMul.ForeColor = SystemColors.WindowFrame;
            btMul.Location = new Point(126, 85);
            btMul.Name = "btMul";
            btMul.Size = new Size(35, 35);
            btMul.TabIndex = 3;
            btMul.TabStop = false;
            btMul.Text = "x";
            btMul.UseVisualStyleBackColor = false;
            btMul.Click += btMul_Click;
            // 
            // bt4
            // 
            bt4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt4.AutoSize = true;
            bt4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt4.Cursor = Cursors.Hand;
            bt4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt4.Location = new Point(3, 85);
            bt4.Name = "bt4";
            bt4.Size = new Size(35, 35);
            bt4.TabIndex = 3;
            bt4.TabStop = false;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // bt7
            // 
            bt7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt7.AutoSize = true;
            bt7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt7.Cursor = Cursors.Hand;
            bt7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt7.Location = new Point(3, 44);
            bt7.Name = "bt7";
            bt7.Size = new Size(35, 35);
            bt7.TabIndex = 3;
            bt7.TabStop = false;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // btCalc
            // 
            btCalc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btCalc.AutoSize = true;
            btCalc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCalc.BackColor = SystemColors.ActiveCaption;
            btCalc.Cursor = Cursors.Hand;
            btCalc.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCalc.ForeColor = SystemColors.ControlLightLight;
            btCalc.Location = new Point(85, 167);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(35, 36);
            btCalc.TabIndex = 3;
            btCalc.TabStop = false;
            btCalc.Text = "=";
            btCalc.UseVisualStyleBackColor = false;
            btCalc.Click += btCalc_Click;
            // 
            // btSub
            // 
            btSub.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btSub.AutoSize = true;
            btSub.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSub.Cursor = Cursors.Hand;
            btSub.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSub.ForeColor = SystemColors.WindowFrame;
            btSub.Location = new Point(126, 126);
            btSub.Name = "btSub";
            btSub.Size = new Size(35, 35);
            btSub.TabIndex = 3;
            btSub.TabStop = false;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = false;
            btSub.Click += btSub_Click;
            // 
            // btOutput
            // 
            btOutput.Cursor = Cursors.Hand;
            btOutput.Dock = DockStyle.Top;
            btOutput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btOutput.Location = new Point(0, 53);
            btOutput.Name = "btOutput";
            btOutput.Size = new Size(164, 37);
            btOutput.TabIndex = 4;
            btOutput.TabStop = false;
            btOutput.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
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
            KeyPress += Calculator_KeyPress;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private ToolStripMenuItem MenuTopMost;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem MenuInfo;
    }
}