﻿namespace Calculator
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            menuStrip = new MenuStrip();
            StripMenuMode = new ToolStripMenuItem();
            MenuModeSim = new ToolStripMenuItem();
            MenuModeAdv = new ToolStripMenuItem();
            MenuModePro = new ToolStripMenuItem();
            StripMenuEdit = new ToolStripMenuItem();
            MenuEditTopmost = new ToolStripMenuItem();
            MenuEditDarkmode = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            MenuEditDebug = new ToolStripMenuItem();
            StripMenuVersion = new ToolStripMenuItem();
            StripMenuInfo = new ToolStripMenuItem();
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
            tableLayoutButtons = new TableLayoutPanel();
            btF = new Button();
            btE = new Button();
            btD = new Button();
            btC = new Button();
            btB = new Button();
            btA = new Button();
            btAnswer = new Button();
            btFactorial = new Button();
            btBracketClose = new Button();
            btBracketOpen = new Button();
            btPow = new Button();
            btModulo = new Button();
            btSqrt = new Button();
            btNegate = new Button();
            btReciprocal = new Button();
            btPi = new Button();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutBase = new TableLayoutPanel();
            btBin = new Button();
            btOct = new Button();
            btDec = new Button();
            rbBin = new RadioButton();
            rbOct = new RadioButton();
            rbDec = new RadioButton();
            rbHex = new RadioButton();
            btHex = new Button();
            txtInput = new RichTextBox();
            txtEval = new RichTextBox();
            menuStrip.SuspendLayout();
            tableLayoutButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutBase.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { StripMenuMode, StripMenuEdit, StripMenuVersion, StripMenuInfo });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(433, 24);
            menuStrip.TabIndex = 1;
            // 
            // StripMenuMode
            // 
            StripMenuMode.DropDownItems.AddRange(new ToolStripItem[] { MenuModeSim, MenuModeAdv, MenuModePro });
            StripMenuMode.Name = "StripMenuMode";
            StripMenuMode.Size = new Size(50, 20);
            StripMenuMode.Text = "Mode";
            // 
            // MenuModeSim
            // 
            MenuModeSim.Name = "MenuModeSim";
            MenuModeSim.ShortcutKeys = Keys.F2;
            MenuModeSim.Size = new Size(160, 22);
            MenuModeSim.Text = "Simple";
            MenuModeSim.Click += MenuModeSim_Click;
            // 
            // MenuModeAdv
            // 
            MenuModeAdv.Name = "MenuModeAdv";
            MenuModeAdv.ShortcutKeys = Keys.F3;
            MenuModeAdv.Size = new Size(160, 22);
            MenuModeAdv.Text = "Advanced";
            MenuModeAdv.Click += MenuModeAdv_Click;
            // 
            // MenuModePro
            // 
            MenuModePro.Checked = true;
            MenuModePro.CheckState = CheckState.Checked;
            MenuModePro.Name = "MenuModePro";
            MenuModePro.ShortcutKeys = Keys.F4;
            MenuModePro.Size = new Size(160, 22);
            MenuModePro.Text = "Programmer";
            MenuModePro.Click += MenuModePro_Click;
            // 
            // StripMenuEdit
            // 
            StripMenuEdit.DropDownItems.AddRange(new ToolStripItem[] { MenuEditTopmost, MenuEditDarkmode, toolStripSeparator, MenuEditDebug });
            StripMenuEdit.Name = "StripMenuEdit";
            StripMenuEdit.Size = new Size(39, 20);
            StripMenuEdit.Text = "Edit";
            // 
            // MenuEditTopmost
            // 
            MenuEditTopmost.Checked = true;
            MenuEditTopmost.CheckState = CheckState.Checked;
            MenuEditTopmost.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuEditTopmost.Name = "MenuEditTopmost";
            MenuEditTopmost.ShortcutKeys = Keys.F9;
            MenuEditTopmost.Size = new Size(169, 22);
            MenuEditTopmost.Text = "Always on Top";
            MenuEditTopmost.Click += MenuEditTopmost_Click;
            // 
            // MenuEditDarkmode
            // 
            MenuEditDarkmode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuEditDarkmode.Name = "MenuEditDarkmode";
            MenuEditDarkmode.ShortcutKeys = Keys.F10;
            MenuEditDarkmode.Size = new Size(169, 22);
            MenuEditDarkmode.Text = "Darkmode";
            MenuEditDarkmode.Click += MenuDarkmode_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(166, 6);
            // 
            // MenuEditDebug
            // 
            MenuEditDebug.Name = "MenuEditDebug";
            MenuEditDebug.ShortcutKeys = Keys.F12;
            MenuEditDebug.Size = new Size(169, 22);
            MenuEditDebug.Text = "Debug Mode";
            MenuEditDebug.Click += MenuEditDebug_Click;
            // 
            // StripMenuVersion
            // 
            StripMenuVersion.Alignment = ToolStripItemAlignment.Right;
            StripMenuVersion.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StripMenuVersion.ForeColor = SystemColors.ControlDarkDark;
            StripMenuVersion.Name = "StripMenuVersion";
            StripMenuVersion.ShortcutKeys = Keys.F1;
            StripMenuVersion.Size = new Size(56, 20);
            StripMenuVersion.Text = "Version";
            StripMenuVersion.TextDirection = ToolStripTextDirection.Horizontal;
            StripMenuVersion.Click += StripMenuVersion_Click;
            // 
            // StripMenuInfo
            // 
            StripMenuInfo.Alignment = ToolStripItemAlignment.Right;
            StripMenuInfo.Enabled = false;
            StripMenuInfo.ForeColor = SystemColors.ControlDarkDark;
            StripMenuInfo.Name = "StripMenuInfo";
            StripMenuInfo.Size = new Size(12, 20);
            StripMenuInfo.Visible = false;
            // 
            // bt9
            // 
            bt9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt9.AutoSize = true;
            bt9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt9.Cursor = Cursors.Hand;
            bt9.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt9.FlatAppearance.BorderSize = 2;
            bt9.FlatStyle = FlatStyle.Flat;
            bt9.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt9.Location = new Point(216, 129);
            bt9.Name = "bt9";
            bt9.Size = new Size(65, 57);
            bt9.TabIndex = 3;
            bt9.TabStop = false;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = false;
            bt9.Click += bt9_Click;
            // 
            // btDelete
            // 
            btDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btDelete.AutoSize = true;
            btDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutButtons.SetColumnSpan(btDelete, 2);
            btDelete.Cursor = Cursors.Hand;
            btDelete.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btDelete.FlatAppearance.BorderSize = 2;
            btDelete.FlatStyle = FlatStyle.Flat;
            btDelete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btDelete.ForeColor = SystemColors.WindowFrame;
            btDelete.Location = new Point(74, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(136, 57);
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
            bt0.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt0.FlatAppearance.BorderSize = 2;
            bt0.FlatStyle = FlatStyle.Flat;
            bt0.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt0.Location = new Point(145, 318);
            bt0.Name = "bt0";
            bt0.Size = new Size(65, 60);
            bt0.TabIndex = 3;
            bt0.TabStop = false;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = false;
            bt0.Click += bt0_Click;
            // 
            // bt6
            // 
            bt6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt6.AutoSize = true;
            bt6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt6.Cursor = Cursors.Hand;
            bt6.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt6.FlatAppearance.BorderSize = 2;
            bt6.FlatStyle = FlatStyle.Flat;
            bt6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt6.Location = new Point(216, 192);
            bt6.Name = "bt6";
            bt6.Size = new Size(65, 57);
            bt6.TabIndex = 3;
            bt6.TabStop = false;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = false;
            bt6.Click += bt6_Click;
            // 
            // bt2
            // 
            bt2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt2.AutoSize = true;
            bt2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt2.Cursor = Cursors.Hand;
            bt2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt2.FlatAppearance.BorderSize = 2;
            bt2.FlatStyle = FlatStyle.Flat;
            bt2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt2.Location = new Point(145, 255);
            bt2.Name = "bt2";
            bt2.Size = new Size(65, 57);
            bt2.TabIndex = 3;
            bt2.TabStop = false;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt3.AutoSize = true;
            bt3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt3.Cursor = Cursors.Hand;
            bt3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt3.FlatAppearance.BorderSize = 2;
            bt3.FlatStyle = FlatStyle.Flat;
            bt3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt3.Location = new Point(216, 255);
            bt3.Name = "bt3";
            bt3.Size = new Size(65, 57);
            bt3.TabIndex = 3;
            bt3.TabStop = false;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += bt3_Click;
            // 
            // bt5
            // 
            bt5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt5.AutoSize = true;
            bt5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt5.Cursor = Cursors.Hand;
            bt5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt5.FlatAppearance.BorderSize = 2;
            bt5.FlatStyle = FlatStyle.Flat;
            bt5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt5.Location = new Point(145, 192);
            bt5.Name = "bt5";
            bt5.Size = new Size(65, 57);
            bt5.TabIndex = 3;
            bt5.TabStop = false;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = false;
            bt5.Click += bt5_Click;
            // 
            // btAdd
            // 
            btAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAdd.AutoSize = true;
            btAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btAdd.Cursor = Cursors.Hand;
            btAdd.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btAdd.FlatAppearance.BorderSize = 2;
            btAdd.FlatStyle = FlatStyle.Flat;
            btAdd.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btAdd.ForeColor = SystemColors.WindowFrame;
            btAdd.Location = new Point(287, 318);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(65, 60);
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
            bt8.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt8.FlatAppearance.BorderSize = 2;
            bt8.FlatStyle = FlatStyle.Flat;
            bt8.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt8.Location = new Point(145, 129);
            bt8.Name = "bt8";
            bt8.Size = new Size(65, 57);
            bt8.TabIndex = 3;
            bt8.TabStop = false;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = false;
            bt8.Click += bt8_Click;
            // 
            // btDiv
            // 
            btDiv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btDiv.AutoSize = true;
            btDiv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btDiv.Cursor = Cursors.Hand;
            btDiv.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btDiv.FlatAppearance.BorderSize = 2;
            btDiv.FlatStyle = FlatStyle.Flat;
            btDiv.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btDiv.ForeColor = SystemColors.WindowFrame;
            btDiv.Location = new Point(287, 129);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(65, 57);
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
            btCom.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btCom.FlatAppearance.BorderSize = 2;
            btCom.FlatStyle = FlatStyle.Flat;
            btCom.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCom.ForeColor = SystemColors.WindowFrame;
            btCom.Location = new Point(74, 318);
            btCom.Name = "btCom";
            btCom.Size = new Size(65, 60);
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
            tableLayoutButtons.SetColumnSpan(btClear, 2);
            btClear.Cursor = Cursors.Hand;
            btClear.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btClear.FlatAppearance.BorderSize = 2;
            btClear.FlatStyle = FlatStyle.Flat;
            btClear.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btClear.ForeColor = SystemColors.WindowFrame;
            btClear.Location = new Point(216, 3);
            btClear.Name = "btClear";
            btClear.Size = new Size(136, 57);
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
            bt1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt1.FlatAppearance.BorderSize = 2;
            bt1.FlatStyle = FlatStyle.Flat;
            bt1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(74, 255);
            bt1.Name = "bt1";
            bt1.Size = new Size(65, 57);
            bt1.TabIndex = 3;
            bt1.TabStop = false;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += bt1_Click;
            // 
            // btMul
            // 
            btMul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btMul.AutoSize = true;
            btMul.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btMul.Cursor = Cursors.Hand;
            btMul.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btMul.FlatAppearance.BorderSize = 2;
            btMul.FlatStyle = FlatStyle.Flat;
            btMul.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btMul.ForeColor = SystemColors.WindowFrame;
            btMul.Location = new Point(287, 192);
            btMul.Name = "btMul";
            btMul.Size = new Size(65, 57);
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
            bt4.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt4.FlatAppearance.BorderSize = 2;
            bt4.FlatStyle = FlatStyle.Flat;
            bt4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt4.Location = new Point(74, 192);
            bt4.Name = "bt4";
            bt4.Size = new Size(65, 57);
            bt4.TabIndex = 3;
            bt4.TabStop = false;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = false;
            bt4.Click += bt4_Click;
            // 
            // bt7
            // 
            bt7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt7.AutoSize = true;
            bt7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt7.Cursor = Cursors.Hand;
            bt7.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            bt7.FlatAppearance.BorderSize = 2;
            bt7.FlatStyle = FlatStyle.Flat;
            bt7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt7.Location = new Point(74, 129);
            bt7.Name = "bt7";
            bt7.Size = new Size(65, 57);
            bt7.TabIndex = 3;
            bt7.TabStop = false;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = false;
            bt7.Click += bt7_Click;
            // 
            // btCalc
            // 
            btCalc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btCalc.AutoSize = true;
            btCalc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCalc.BackColor = SystemColors.ActiveCaption;
            btCalc.Cursor = Cursors.Hand;
            btCalc.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btCalc.FlatAppearance.BorderSize = 2;
            btCalc.FlatStyle = FlatStyle.Flat;
            btCalc.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCalc.ForeColor = SystemColors.ControlLightLight;
            btCalc.Location = new Point(216, 318);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(65, 60);
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
            btSub.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btSub.FlatAppearance.BorderSize = 2;
            btSub.FlatStyle = FlatStyle.Flat;
            btSub.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSub.ForeColor = SystemColors.WindowFrame;
            btSub.Location = new Point(287, 255);
            btSub.Name = "btSub";
            btSub.Size = new Size(65, 57);
            btSub.TabIndex = 3;
            btSub.TabStop = false;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = false;
            btSub.Click += btSub_Click;
            // 
            // tableLayoutButtons
            // 
            tableLayoutButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutButtons.AutoSize = true;
            tableLayoutButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutButtons.ColumnCount = 6;
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutButtons.Controls.Add(btCalc, 3, 5);
            tableLayoutButtons.Controls.Add(bt0, 2, 5);
            tableLayoutButtons.Controls.Add(btCom, 1, 5);
            tableLayoutButtons.Controls.Add(bt3, 3, 4);
            tableLayoutButtons.Controls.Add(btF, 0, 5);
            tableLayoutButtons.Controls.Add(btE, 0, 4);
            tableLayoutButtons.Controls.Add(btD, 0, 3);
            tableLayoutButtons.Controls.Add(btC, 0, 2);
            tableLayoutButtons.Controls.Add(btB, 0, 1);
            tableLayoutButtons.Controls.Add(btA, 0, 0);
            tableLayoutButtons.Controls.Add(bt2, 2, 4);
            tableLayoutButtons.Controls.Add(bt1, 1, 4);
            tableLayoutButtons.Controls.Add(bt4, 1, 3);
            tableLayoutButtons.Controls.Add(bt5, 2, 3);
            tableLayoutButtons.Controls.Add(bt6, 3, 3);
            tableLayoutButtons.Controls.Add(bt9, 3, 2);
            tableLayoutButtons.Controls.Add(bt8, 2, 2);
            tableLayoutButtons.Controls.Add(bt7, 1, 2);
            tableLayoutButtons.Controls.Add(btAdd, 4, 5);
            tableLayoutButtons.Controls.Add(btSub, 4, 4);
            tableLayoutButtons.Controls.Add(btMul, 4, 3);
            tableLayoutButtons.Controls.Add(btDelete, 1, 0);
            tableLayoutButtons.Controls.Add(btClear, 3, 0);
            tableLayoutButtons.Controls.Add(btAnswer, 5, 0);
            tableLayoutButtons.Controls.Add(btFactorial, 5, 1);
            tableLayoutButtons.Controls.Add(btBracketClose, 2, 1);
            tableLayoutButtons.Controls.Add(btBracketOpen, 1, 1);
            tableLayoutButtons.Controls.Add(btDiv, 4, 2);
            tableLayoutButtons.Controls.Add(btPow, 3, 1);
            tableLayoutButtons.Controls.Add(btModulo, 5, 5);
            tableLayoutButtons.Controls.Add(btSqrt, 4, 1);
            tableLayoutButtons.Controls.Add(btNegate, 5, 2);
            tableLayoutButtons.Controls.Add(btReciprocal, 5, 3);
            tableLayoutButtons.Controls.Add(btPi, 5, 4);
            tableLayoutButtons.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutButtons.Location = new Point(3, 164);
            tableLayoutButtons.Margin = new Padding(0);
            tableLayoutButtons.Name = "tableLayoutButtons";
            tableLayoutButtons.RowCount = 6;
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.Size = new Size(427, 381);
            tableLayoutButtons.TabIndex = 5;
            // 
            // btF
            // 
            btF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btF.AutoSize = true;
            btF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btF.Cursor = Cursors.Hand;
            btF.Enabled = false;
            btF.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btF.FlatAppearance.BorderSize = 2;
            btF.FlatStyle = FlatStyle.Flat;
            btF.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btF.Location = new Point(3, 318);
            btF.Name = "btF";
            btF.Size = new Size(65, 60);
            btF.TabIndex = 9;
            btF.TabStop = false;
            btF.Text = "F";
            btF.UseVisualStyleBackColor = false;
            btF.Click += btF_Click;
            // 
            // btE
            // 
            btE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btE.AutoSize = true;
            btE.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btE.Cursor = Cursors.Hand;
            btE.Enabled = false;
            btE.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btE.FlatAppearance.BorderSize = 2;
            btE.FlatStyle = FlatStyle.Flat;
            btE.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btE.Location = new Point(3, 255);
            btE.Name = "btE";
            btE.Size = new Size(65, 57);
            btE.TabIndex = 8;
            btE.TabStop = false;
            btE.Text = "E";
            btE.UseVisualStyleBackColor = false;
            btE.Click += btE_Click;
            // 
            // btD
            // 
            btD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btD.AutoSize = true;
            btD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btD.Cursor = Cursors.Hand;
            btD.Enabled = false;
            btD.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btD.FlatAppearance.BorderSize = 2;
            btD.FlatStyle = FlatStyle.Flat;
            btD.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btD.Location = new Point(3, 192);
            btD.Name = "btD";
            btD.Size = new Size(65, 57);
            btD.TabIndex = 7;
            btD.TabStop = false;
            btD.Text = "D";
            btD.UseVisualStyleBackColor = false;
            btD.Click += btD_Click;
            // 
            // btC
            // 
            btC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btC.AutoSize = true;
            btC.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btC.Cursor = Cursors.Hand;
            btC.Enabled = false;
            btC.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btC.FlatAppearance.BorderSize = 2;
            btC.FlatStyle = FlatStyle.Flat;
            btC.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btC.Location = new Point(3, 129);
            btC.Name = "btC";
            btC.Size = new Size(65, 57);
            btC.TabIndex = 6;
            btC.TabStop = false;
            btC.Text = "C";
            btC.UseVisualStyleBackColor = false;
            btC.Click += btC_Click;
            // 
            // btB
            // 
            btB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btB.AutoSize = true;
            btB.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btB.Cursor = Cursors.Hand;
            btB.Enabled = false;
            btB.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btB.FlatAppearance.BorderSize = 2;
            btB.FlatStyle = FlatStyle.Flat;
            btB.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btB.Location = new Point(3, 66);
            btB.Name = "btB";
            btB.Size = new Size(65, 57);
            btB.TabIndex = 5;
            btB.TabStop = false;
            btB.Text = "B";
            btB.UseVisualStyleBackColor = false;
            btB.Click += btB_Click;
            // 
            // btA
            // 
            btA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btA.AutoSize = true;
            btA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btA.Cursor = Cursors.Hand;
            btA.Enabled = false;
            btA.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btA.FlatAppearance.BorderSize = 2;
            btA.FlatStyle = FlatStyle.Flat;
            btA.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btA.Location = new Point(3, 3);
            btA.Name = "btA";
            btA.Size = new Size(65, 57);
            btA.TabIndex = 10;
            btA.TabStop = false;
            btA.Text = "A";
            btA.UseVisualStyleBackColor = false;
            btA.Click += btA_Click;
            // 
            // btAnswer
            // 
            btAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAnswer.AutoSize = true;
            btAnswer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btAnswer.Cursor = Cursors.Hand;
            btAnswer.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btAnswer.FlatAppearance.BorderSize = 2;
            btAnswer.FlatStyle = FlatStyle.Flat;
            btAnswer.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btAnswer.ForeColor = SystemColors.WindowFrame;
            btAnswer.Location = new Point(358, 3);
            btAnswer.Name = "btAnswer";
            btAnswer.Size = new Size(66, 57);
            btAnswer.TabIndex = 3;
            btAnswer.TabStop = false;
            btAnswer.Text = "📋";
            btAnswer.UseVisualStyleBackColor = false;
            btAnswer.Click += btCopy_Click;
            // 
            // btFactorial
            // 
            btFactorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btFactorial.AutoSize = true;
            btFactorial.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btFactorial.Cursor = Cursors.Hand;
            btFactorial.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btFactorial.FlatAppearance.BorderSize = 2;
            btFactorial.FlatStyle = FlatStyle.Flat;
            btFactorial.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btFactorial.ForeColor = SystemColors.WindowFrame;
            btFactorial.Location = new Point(358, 66);
            btFactorial.Name = "btFactorial";
            btFactorial.Size = new Size(66, 57);
            btFactorial.TabIndex = 4;
            btFactorial.TabStop = false;
            btFactorial.Text = "n!";
            btFactorial.UseVisualStyleBackColor = false;
            btFactorial.Click += btFactorial_Click;
            // 
            // btBracketClose
            // 
            btBracketClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btBracketClose.AutoSize = true;
            btBracketClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btBracketClose.Cursor = Cursors.Hand;
            btBracketClose.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btBracketClose.FlatAppearance.BorderSize = 2;
            btBracketClose.FlatStyle = FlatStyle.Flat;
            btBracketClose.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btBracketClose.ForeColor = SystemColors.WindowFrame;
            btBracketClose.Location = new Point(145, 66);
            btBracketClose.Name = "btBracketClose";
            btBracketClose.Size = new Size(65, 57);
            btBracketClose.TabIndex = 12;
            btBracketClose.TabStop = false;
            btBracketClose.Text = ")";
            btBracketClose.UseVisualStyleBackColor = false;
            btBracketClose.Click += btBracketClose_Click;
            // 
            // btBracketOpen
            // 
            btBracketOpen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btBracketOpen.AutoSize = true;
            btBracketOpen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btBracketOpen.Cursor = Cursors.Hand;
            btBracketOpen.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btBracketOpen.FlatAppearance.BorderSize = 2;
            btBracketOpen.FlatStyle = FlatStyle.Flat;
            btBracketOpen.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btBracketOpen.ForeColor = SystemColors.WindowFrame;
            btBracketOpen.Location = new Point(74, 66);
            btBracketOpen.Name = "btBracketOpen";
            btBracketOpen.Size = new Size(65, 57);
            btBracketOpen.TabIndex = 11;
            btBracketOpen.TabStop = false;
            btBracketOpen.Text = "(";
            btBracketOpen.UseVisualStyleBackColor = false;
            btBracketOpen.Click += btBracketOpen_Click;
            // 
            // btPow
            // 
            btPow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btPow.AutoSize = true;
            btPow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btPow.Cursor = Cursors.Hand;
            btPow.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btPow.FlatAppearance.BorderSize = 2;
            btPow.FlatStyle = FlatStyle.Flat;
            btPow.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btPow.ForeColor = SystemColors.WindowFrame;
            btPow.Location = new Point(216, 66);
            btPow.Name = "btPow";
            btPow.Size = new Size(65, 57);
            btPow.TabIndex = 4;
            btPow.TabStop = false;
            btPow.Text = "x^y";
            btPow.UseVisualStyleBackColor = false;
            btPow.Click += btPow_Click;
            // 
            // btModulo
            // 
            btModulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btModulo.AutoSize = true;
            btModulo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btModulo.Cursor = Cursors.Hand;
            btModulo.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btModulo.FlatAppearance.BorderSize = 2;
            btModulo.FlatStyle = FlatStyle.Flat;
            btModulo.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btModulo.ForeColor = SystemColors.WindowFrame;
            btModulo.Location = new Point(358, 318);
            btModulo.Name = "btModulo";
            btModulo.Size = new Size(66, 60);
            btModulo.TabIndex = 13;
            btModulo.TabStop = false;
            btModulo.Text = "%";
            btModulo.UseVisualStyleBackColor = false;
            btModulo.Click += btModulo_Click;
            // 
            // btSqrt
            // 
            btSqrt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btSqrt.AutoSize = true;
            btSqrt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSqrt.Cursor = Cursors.Hand;
            btSqrt.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btSqrt.FlatAppearance.BorderSize = 2;
            btSqrt.FlatStyle = FlatStyle.Flat;
            btSqrt.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSqrt.ForeColor = SystemColors.WindowFrame;
            btSqrt.Location = new Point(287, 66);
            btSqrt.Name = "btSqrt";
            btSqrt.Size = new Size(65, 57);
            btSqrt.TabIndex = 4;
            btSqrt.TabStop = false;
            btSqrt.Text = "√";
            btSqrt.UseVisualStyleBackColor = false;
            btSqrt.Click += btSqrt_Click;
            // 
            // btNegate
            // 
            btNegate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btNegate.AutoSize = true;
            btNegate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btNegate.Cursor = Cursors.Hand;
            btNegate.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btNegate.FlatAppearance.BorderSize = 2;
            btNegate.FlatStyle = FlatStyle.Flat;
            btNegate.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btNegate.ForeColor = SystemColors.WindowFrame;
            btNegate.Location = new Point(358, 129);
            btNegate.Name = "btNegate";
            btNegate.Size = new Size(66, 57);
            btNegate.TabIndex = 14;
            btNegate.TabStop = false;
            btNegate.Text = "±";
            btNegate.UseVisualStyleBackColor = false;
            btNegate.Click += btNegate_Click;
            // 
            // btReciprocal
            // 
            btReciprocal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btReciprocal.AutoSize = true;
            btReciprocal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btReciprocal.Cursor = Cursors.Hand;
            btReciprocal.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btReciprocal.FlatAppearance.BorderSize = 2;
            btReciprocal.FlatStyle = FlatStyle.Flat;
            btReciprocal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btReciprocal.ForeColor = SystemColors.WindowFrame;
            btReciprocal.Location = new Point(358, 192);
            btReciprocal.Name = "btReciprocal";
            btReciprocal.Size = new Size(66, 57);
            btReciprocal.TabIndex = 15;
            btReciprocal.TabStop = false;
            btReciprocal.Text = "1/n";
            btReciprocal.UseVisualStyleBackColor = false;
            btReciprocal.Click += btReciprocal_Click;
            // 
            // btPi
            // 
            btPi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btPi.AutoSize = true;
            btPi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btPi.Cursor = Cursors.Hand;
            btPi.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btPi.FlatAppearance.BorderSize = 2;
            btPi.FlatStyle = FlatStyle.Flat;
            btPi.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btPi.ForeColor = SystemColors.WindowFrame;
            btPi.Location = new Point(358, 255);
            btPi.Name = "btPi";
            btPi.Size = new Size(66, 57);
            btPi.TabIndex = 4;
            btPi.TabStop = false;
            btPi.Text = "π";
            btPi.UseVisualStyleBackColor = false;
            btPi.Click += btPi_Click;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutBase, 0, 2);
            tableLayoutMain.Controls.Add(tableLayoutButtons, 0, 3);
            tableLayoutMain.Controls.Add(txtInput, 0, 1);
            tableLayoutMain.Controls.Add(txtEval, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 24);
            tableLayoutMain.Margin = new Padding(0);
            tableLayoutMain.MinimumSize = new Size(200, 300);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.Padding = new Padding(3);
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutMain.Size = new Size(433, 548);
            tableLayoutMain.TabIndex = 6;
            // 
            // tableLayoutBase
            // 
            tableLayoutBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutBase.ColumnCount = 2;
            tableLayoutBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0023861F));
            tableLayoutBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.99761F));
            tableLayoutBase.Controls.Add(btBin, 1, 3);
            tableLayoutBase.Controls.Add(btOct, 1, 2);
            tableLayoutBase.Controls.Add(btDec, 1, 1);
            tableLayoutBase.Controls.Add(rbBin, 0, 3);
            tableLayoutBase.Controls.Add(rbOct, 0, 2);
            tableLayoutBase.Controls.Add(rbDec, 0, 1);
            tableLayoutBase.Controls.Add(rbHex, 0, 0);
            tableLayoutBase.Controls.Add(btHex, 1, 0);
            tableLayoutBase.Location = new Point(3, 70);
            tableLayoutBase.Margin = new Padding(0);
            tableLayoutBase.Name = "tableLayoutBase";
            tableLayoutBase.RowCount = 4;
            tableLayoutBase.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutBase.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutBase.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutBase.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutBase.Size = new Size(427, 94);
            tableLayoutBase.TabIndex = 17;
            // 
            // btBin
            // 
            btBin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btBin.Cursor = Cursors.IBeam;
            btBin.FlatAppearance.BorderSize = 0;
            btBin.FlatStyle = FlatStyle.Flat;
            btBin.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btBin.Location = new Point(89, 69);
            btBin.Margin = new Padding(0);
            btBin.Name = "btBin";
            btBin.Size = new Size(338, 25);
            btBin.TabIndex = 15;
            btBin.Text = "0";
            btBin.TextAlign = ContentAlignment.MiddleLeft;
            btBin.UseVisualStyleBackColor = true;
            btBin.Click += btBin_Click;
            // 
            // btOct
            // 
            btOct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btOct.Cursor = Cursors.IBeam;
            btOct.FlatAppearance.BorderSize = 0;
            btOct.FlatStyle = FlatStyle.Flat;
            btOct.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btOct.Location = new Point(89, 46);
            btOct.Margin = new Padding(0);
            btOct.Name = "btOct";
            btOct.Size = new Size(338, 23);
            btOct.TabIndex = 14;
            btOct.Text = "0";
            btOct.TextAlign = ContentAlignment.MiddleLeft;
            btOct.UseVisualStyleBackColor = true;
            btOct.Click += btOct_Click;
            // 
            // btDec
            // 
            btDec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btDec.Cursor = Cursors.IBeam;
            btDec.FlatAppearance.BorderSize = 0;
            btDec.FlatStyle = FlatStyle.Flat;
            btDec.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btDec.Location = new Point(89, 23);
            btDec.Margin = new Padding(0);
            btDec.Name = "btDec";
            btDec.Size = new Size(338, 23);
            btDec.TabIndex = 13;
            btDec.Text = "0";
            btDec.TextAlign = ContentAlignment.MiddleLeft;
            btDec.UseVisualStyleBackColor = true;
            btDec.Click += btDec_Click;
            // 
            // rbBin
            // 
            rbBin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbBin.AutoSize = true;
            rbBin.Cursor = Cursors.Hand;
            rbBin.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbBin.Location = new Point(3, 72);
            rbBin.Name = "rbBin";
            rbBin.Size = new Size(83, 19);
            rbBin.TabIndex = 11;
            rbBin.Text = "Bin  (2)";
            rbBin.TextAlign = ContentAlignment.MiddleCenter;
            rbBin.UseVisualStyleBackColor = true;
            rbBin.CheckedChanged += rbBin_CheckedChanged;
            // 
            // rbOct
            // 
            rbOct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbOct.AutoSize = true;
            rbOct.Cursor = Cursors.Hand;
            rbOct.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbOct.Location = new Point(3, 49);
            rbOct.Name = "rbOct";
            rbOct.Size = new Size(83, 17);
            rbOct.TabIndex = 11;
            rbOct.Text = "Oct  (8)";
            rbOct.TextAlign = ContentAlignment.MiddleCenter;
            rbOct.UseVisualStyleBackColor = true;
            rbOct.CheckedChanged += rbOct_CheckedChanged;
            // 
            // rbDec
            // 
            rbDec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbDec.AutoSize = true;
            rbDec.Checked = true;
            rbDec.Cursor = Cursors.Hand;
            rbDec.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbDec.Location = new Point(3, 26);
            rbDec.Name = "rbDec";
            rbDec.Size = new Size(83, 17);
            rbDec.TabIndex = 11;
            rbDec.TabStop = true;
            rbDec.Text = "Dec (10)";
            rbDec.TextAlign = ContentAlignment.MiddleCenter;
            rbDec.UseVisualStyleBackColor = true;
            rbDec.CheckedChanged += rbDec_CheckedChanged;
            // 
            // rbHex
            // 
            rbHex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbHex.AutoSize = true;
            rbHex.Cursor = Cursors.Hand;
            rbHex.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbHex.Location = new Point(3, 3);
            rbHex.Name = "rbHex";
            rbHex.Size = new Size(83, 17);
            rbHex.TabIndex = 0;
            rbHex.Text = "Hex (16)";
            rbHex.TextAlign = ContentAlignment.MiddleCenter;
            rbHex.UseVisualStyleBackColor = true;
            rbHex.CheckedChanged += rbHex_CheckedChanged;
            // 
            // btHex
            // 
            btHex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btHex.Cursor = Cursors.IBeam;
            btHex.FlatAppearance.BorderSize = 0;
            btHex.FlatStyle = FlatStyle.Flat;
            btHex.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btHex.Location = new Point(89, 0);
            btHex.Margin = new Padding(0);
            btHex.Name = "btHex";
            btHex.Size = new Size(338, 23);
            btHex.TabIndex = 12;
            btHex.Text = "0";
            btHex.TextAlign = ContentAlignment.MiddleLeft;
            btHex.UseVisualStyleBackColor = true;
            btHex.Click += btHex_Click;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(6, 30);
            txtInput.Margin = new Padding(3, 0, 3, 3);
            txtInput.Name = "txtInput";
            txtInput.ReadOnly = true;
            txtInput.ScrollBars = RichTextBoxScrollBars.None;
            txtInput.Size = new Size(421, 37);
            txtInput.TabIndex = 12;
            txtInput.Text = "";
            txtInput.SizeChanged += txtInput_SizeChanged;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // txtEval
            // 
            txtEval.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEval.BorderStyle = BorderStyle.None;
            txtEval.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEval.Location = new Point(6, 6);
            txtEval.Margin = new Padding(3, 3, 3, 0);
            txtEval.Name = "txtEval";
            txtEval.ReadOnly = true;
            txtEval.ScrollBars = RichTextBoxScrollBars.None;
            txtEval.Size = new Size(421, 24);
            txtEval.TabIndex = 13;
            txtEval.Text = "";
            txtEval.SizeChanged += txtEval_SizeChanged;
            txtEval.TextChanged += txtEval_TextChanged;
            // 
            // Interface
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(433, 572);
            Controls.Add(tableLayoutMain);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(446, 611);
            Name = "Interface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            TopMost = true;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tableLayoutButtons.ResumeLayout(false);
            tableLayoutButtons.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutBase.ResumeLayout(false);
            tableLayoutBase.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private TableLayoutPanel tableLayoutButtons;
        private ToolStripMenuItem StripMenuEdit;
        private ToolStripMenuItem StripMenuMode;
        private ToolStripMenuItem MenuModeSim;
        private ToolStripMenuItem MenuModeAdv;
        private ToolStripMenuItem MenuEditTopmost;
        private ToolStripMenuItem MenuEditDarkmode;
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
        private Button btPi;
        private Button btFactorial;
        private Button btSqrt;
        private Button btPow;
        private Button btAnswer;
        private TableLayoutPanel tableLayoutMain;
        private ToolStripMenuItem StripMenuVersion;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem MenuEditDebug;
        private ToolStripMenuItem MenuModePro;
        private Button btF;
        private Button btE;
        private Button btD;
        private Button btC;
        private Button btB;
        private Button btA;
        private Button btBracketOpen;
        private Button btBracketClose;
        private Button btModulo;
        private Button btNegate;
        private Button btReciprocal;
        private RichTextBox txtInput;
        private RichTextBox txtEval;
        private ToolStripMenuItem StripMenuInfo;
        private TableLayoutPanel tableLayoutBase;
        private Button btDec;
        private RadioButton rbBin;
        private RadioButton rbOct;
        private RadioButton rbDec;
        private RadioButton rbHex;
        private Button btHex;
        private Button btBin;
        private Button btOct;
    }
}