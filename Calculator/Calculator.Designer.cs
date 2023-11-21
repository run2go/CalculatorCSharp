namespace Calculator
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
            Bt9 = new Button();
            btDelete = new Button();
            Bt0 = new Button();
            Bt6 = new Button();
            Bt2 = new Button();
            Bt3 = new Button();
            Bt5 = new Button();
            btAdd = new Button();
            Bt8 = new Button();
            btDiv = new Button();
            BtCom = new Button();
            btClear = new Button();
            Bt1 = new Button();
            btMul = new Button();
            Bt4 = new Button();
            Bt7 = new Button();
            btCalc = new Button();
            btSub = new Button();
            TableLayoutButtons = new TableLayoutPanel();
            BtF = new Button();
            BtE = new Button();
            BtD = new Button();
            BtC = new Button();
            BtB = new Button();
            BtA = new Button();
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
            TableLayoutMain = new TableLayoutPanel();
            tableLayoutBase = new TableLayoutPanel();
            BtBase2 = new Button();
            BtBase8 = new Button();
            BtBase10 = new Button();
            rbBase2 = new RadioButton();
            rbBase8 = new RadioButton();
            RbBase10 = new RadioButton();
            rbBase16 = new RadioButton();
            BtBase16 = new Button();
            TbEval = new RichTextBox();
            tableLayoutInput = new TableLayoutPanel();
            TbInput = new RichTextBox();
            TbSymbol = new Label();
            menuStrip.SuspendLayout();
            TableLayoutButtons.SuspendLayout();
            TableLayoutMain.SuspendLayout();
            tableLayoutBase.SuspendLayout();
            tableLayoutInput.SuspendLayout();
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
            MenuModeSim.Click += SwitchMode;
            // 
            // MenuModeAdv
            // 
            MenuModeAdv.Name = "MenuModeAdv";
            MenuModeAdv.ShortcutKeys = Keys.F3;
            MenuModeAdv.Size = new Size(160, 22);
            MenuModeAdv.Text = "Advanced";
            MenuModeAdv.Click += SwitchMode;
            // 
            // MenuModePro
            // 
            MenuModePro.Checked = true;
            MenuModePro.CheckState = CheckState.Checked;
            MenuModePro.Name = "MenuModePro";
            MenuModePro.ShortcutKeys = Keys.F4;
            MenuModePro.Size = new Size(160, 22);
            MenuModePro.Text = "Programmer";
            MenuModePro.Click += SwitchMode;
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
            // Bt9
            // 
            Bt9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt9.AutoSize = true;
            Bt9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt9.Cursor = Cursors.Hand;
            Bt9.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt9.FlatAppearance.BorderSize = 2;
            Bt9.FlatStyle = FlatStyle.Flat;
            Bt9.Location = new Point(216, 129);
            Bt9.Name = "Bt9";
            Bt9.Size = new Size(65, 57);
            Bt9.TabIndex = 3;
            Bt9.TabStop = false;
            Bt9.Text = "9";
            Bt9.UseVisualStyleBackColor = false;
            Bt9.SizeChanged += ObjectHelper_Changed;
            Bt9.Click += BtNumeric_Click;
            // 
            // btDelete
            // 
            btDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btDelete.AutoSize = true;
            btDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutButtons.SetColumnSpan(btDelete, 2);
            btDelete.Cursor = Cursors.Hand;
            btDelete.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btDelete.FlatAppearance.BorderSize = 2;
            btDelete.FlatStyle = FlatStyle.Flat;
            btDelete.ForeColor = SystemColors.WindowFrame;
            btDelete.Location = new Point(74, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(136, 57);
            btDelete.TabIndex = 3;
            btDelete.TabStop = false;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.SizeChanged += Object_Changed;
            btDelete.Click += BtDelete_Click;
            // 
            // Bt0
            // 
            Bt0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt0.AutoSize = true;
            Bt0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt0.Cursor = Cursors.Hand;
            Bt0.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt0.FlatAppearance.BorderSize = 2;
            Bt0.FlatStyle = FlatStyle.Flat;
            Bt0.Location = new Point(145, 318);
            Bt0.Name = "Bt0";
            Bt0.Size = new Size(65, 60);
            Bt0.TabIndex = 3;
            Bt0.TabStop = false;
            Bt0.Text = "0";
            Bt0.UseVisualStyleBackColor = false;
            Bt0.SizeChanged += Object_Changed;
            Bt0.Click += BtNumeric_Click;
            // 
            // Bt6
            // 
            Bt6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt6.AutoSize = true;
            Bt6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt6.Cursor = Cursors.Hand;
            Bt6.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt6.FlatAppearance.BorderSize = 2;
            Bt6.FlatStyle = FlatStyle.Flat;
            Bt6.Location = new Point(216, 192);
            Bt6.Name = "Bt6";
            Bt6.Size = new Size(65, 57);
            Bt6.TabIndex = 3;
            Bt6.TabStop = false;
            Bt6.Text = "6";
            Bt6.UseVisualStyleBackColor = false;
            Bt6.SizeChanged += ObjectHelper_Changed;
            Bt6.Click += BtNumeric_Click;
            // 
            // Bt2
            // 
            Bt2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt2.AutoSize = true;
            Bt2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt2.Cursor = Cursors.Hand;
            Bt2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt2.FlatAppearance.BorderSize = 2;
            Bt2.FlatStyle = FlatStyle.Flat;
            Bt2.Location = new Point(145, 255);
            Bt2.Name = "Bt2";
            Bt2.Size = new Size(65, 57);
            Bt2.TabIndex = 3;
            Bt2.TabStop = false;
            Bt2.Text = "2";
            Bt2.UseVisualStyleBackColor = false;
            Bt2.SizeChanged += ObjectHelper_Changed;
            Bt2.Click += BtNumeric_Click;
            // 
            // Bt3
            // 
            Bt3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt3.AutoSize = true;
            Bt3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt3.Cursor = Cursors.Hand;
            Bt3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt3.FlatAppearance.BorderSize = 2;
            Bt3.FlatStyle = FlatStyle.Flat;
            Bt3.Location = new Point(216, 255);
            Bt3.Name = "Bt3";
            Bt3.Size = new Size(65, 57);
            Bt3.TabIndex = 3;
            Bt3.TabStop = false;
            Bt3.Text = "3";
            Bt3.UseVisualStyleBackColor = false;
            Bt3.SizeChanged += ObjectHelper_Changed;
            Bt3.Click += BtNumeric_Click;
            // 
            // Bt5
            // 
            Bt5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt5.AutoSize = true;
            Bt5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt5.Cursor = Cursors.Hand;
            Bt5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt5.FlatAppearance.BorderSize = 2;
            Bt5.FlatStyle = FlatStyle.Flat;
            Bt5.Location = new Point(145, 192);
            Bt5.Name = "Bt5";
            Bt5.Size = new Size(65, 57);
            Bt5.TabIndex = 3;
            Bt5.TabStop = false;
            Bt5.Text = "5";
            Bt5.UseVisualStyleBackColor = false;
            Bt5.SizeChanged += ObjectHelper_Changed;
            Bt5.Click += BtNumeric_Click;
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
            btAdd.ForeColor = SystemColors.WindowFrame;
            btAdd.Location = new Point(287, 318);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(65, 60);
            btAdd.TabIndex = 3;
            btAdd.TabStop = false;
            btAdd.Text = "+";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.SizeChanged += ObjectHelper_Changed;
            btAdd.Click += BtOperatorRight_Click;
            // 
            // Bt8
            // 
            Bt8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt8.AutoSize = true;
            Bt8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt8.Cursor = Cursors.Hand;
            Bt8.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt8.FlatAppearance.BorderSize = 2;
            Bt8.FlatStyle = FlatStyle.Flat;
            Bt8.Location = new Point(145, 129);
            Bt8.Name = "Bt8";
            Bt8.Size = new Size(65, 57);
            Bt8.TabIndex = 3;
            Bt8.TabStop = false;
            Bt8.Text = "8";
            Bt8.UseVisualStyleBackColor = false;
            Bt8.SizeChanged += ObjectHelper_Changed;
            Bt8.Click += BtNumeric_Click;
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
            btDiv.ForeColor = SystemColors.WindowFrame;
            btDiv.Location = new Point(287, 129);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(65, 57);
            btDiv.TabIndex = 3;
            btDiv.TabStop = false;
            btDiv.Text = "/";
            btDiv.UseVisualStyleBackColor = false;
            btDiv.SizeChanged += ObjectHelper_Changed;
            btDiv.Click += BtOperatorRight_Click;
            // 
            // BtCom
            // 
            BtCom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtCom.AutoSize = true;
            BtCom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtCom.Cursor = Cursors.Hand;
            BtCom.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BtCom.FlatAppearance.BorderSize = 2;
            BtCom.FlatStyle = FlatStyle.Flat;
            BtCom.ForeColor = SystemColors.WindowFrame;
            BtCom.Location = new Point(74, 318);
            BtCom.Name = "BtCom";
            BtCom.Size = new Size(65, 60);
            BtCom.TabIndex = 3;
            BtCom.TabStop = false;
            BtCom.Text = ".";
            BtCom.UseVisualStyleBackColor = false;
            BtCom.SizeChanged += Object_Changed;
            BtCom.Click += BtCom_Click;
            // 
            // btClear
            // 
            btClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btClear.AutoSize = true;
            btClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutButtons.SetColumnSpan(btClear, 2);
            btClear.Cursor = Cursors.Hand;
            btClear.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btClear.FlatAppearance.BorderSize = 2;
            btClear.FlatStyle = FlatStyle.Flat;
            btClear.ForeColor = SystemColors.WindowFrame;
            btClear.Location = new Point(216, 3);
            btClear.Name = "btClear";
            btClear.Size = new Size(136, 57);
            btClear.TabIndex = 3;
            btClear.TabStop = false;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.SizeChanged += Object_Changed;
            btClear.Click += BtClear_Click;
            // 
            // Bt1
            // 
            Bt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt1.AutoSize = true;
            Bt1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt1.Cursor = Cursors.Hand;
            Bt1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt1.FlatAppearance.BorderSize = 2;
            Bt1.FlatStyle = FlatStyle.Flat;
            Bt1.Location = new Point(74, 255);
            Bt1.Name = "Bt1";
            Bt1.Size = new Size(65, 57);
            Bt1.TabIndex = 3;
            Bt1.TabStop = false;
            Bt1.Text = "1";
            Bt1.UseVisualStyleBackColor = false;
            Bt1.SizeChanged += ObjectHelper_Changed;
            Bt1.Click += BtNumeric_Click;
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
            btMul.ForeColor = SystemColors.WindowFrame;
            btMul.Location = new Point(287, 192);
            btMul.Name = "btMul";
            btMul.Size = new Size(65, 57);
            btMul.TabIndex = 3;
            btMul.TabStop = false;
            btMul.Text = "x";
            btMul.UseVisualStyleBackColor = false;
            btMul.SizeChanged += ObjectHelper_Changed;
            btMul.Click += BtOperatorRight_Click;
            // 
            // Bt4
            // 
            Bt4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt4.AutoSize = true;
            Bt4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt4.Cursor = Cursors.Hand;
            Bt4.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt4.FlatAppearance.BorderSize = 2;
            Bt4.FlatStyle = FlatStyle.Flat;
            Bt4.Location = new Point(74, 192);
            Bt4.Name = "Bt4";
            Bt4.Size = new Size(65, 57);
            Bt4.TabIndex = 3;
            Bt4.TabStop = false;
            Bt4.Text = "4";
            Bt4.UseVisualStyleBackColor = false;
            Bt4.SizeChanged += ObjectHelper_Changed;
            Bt4.Click += BtNumeric_Click;
            // 
            // Bt7
            // 
            Bt7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt7.AutoSize = true;
            Bt7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt7.Cursor = Cursors.Hand;
            Bt7.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Bt7.FlatAppearance.BorderSize = 2;
            Bt7.FlatStyle = FlatStyle.Flat;
            Bt7.Location = new Point(74, 129);
            Bt7.Name = "Bt7";
            Bt7.Size = new Size(65, 57);
            Bt7.TabIndex = 3;
            Bt7.TabStop = false;
            Bt7.Text = "7";
            Bt7.UseVisualStyleBackColor = false;
            Bt7.SizeChanged += ObjectHelper_Changed;
            Bt7.Click += BtNumeric_Click;
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
            btCalc.SizeChanged += Object_Changed;
            btCalc.Click += BtCalc_Click;
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
            btSub.ForeColor = SystemColors.WindowFrame;
            btSub.Location = new Point(287, 255);
            btSub.Name = "btSub";
            btSub.Size = new Size(65, 57);
            btSub.TabIndex = 3;
            btSub.TabStop = false;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = false;
            btSub.SizeChanged += ObjectHelper_Changed;
            btSub.Click += BtOperatorRight_Click;
            // 
            // TableLayoutButtons
            // 
            TableLayoutButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutButtons.AutoSize = true;
            TableLayoutButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutButtons.ColumnCount = 6;
            TableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            TableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            TableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            TableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            TableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            TableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            TableLayoutButtons.Controls.Add(btCalc, 3, 5);
            TableLayoutButtons.Controls.Add(Bt0, 2, 5);
            TableLayoutButtons.Controls.Add(BtCom, 1, 5);
            TableLayoutButtons.Controls.Add(Bt3, 3, 4);
            TableLayoutButtons.Controls.Add(BtF, 0, 5);
            TableLayoutButtons.Controls.Add(BtE, 0, 4);
            TableLayoutButtons.Controls.Add(BtD, 0, 3);
            TableLayoutButtons.Controls.Add(BtC, 0, 2);
            TableLayoutButtons.Controls.Add(BtB, 0, 1);
            TableLayoutButtons.Controls.Add(BtA, 0, 0);
            TableLayoutButtons.Controls.Add(Bt2, 2, 4);
            TableLayoutButtons.Controls.Add(Bt1, 1, 4);
            TableLayoutButtons.Controls.Add(Bt4, 1, 3);
            TableLayoutButtons.Controls.Add(Bt5, 2, 3);
            TableLayoutButtons.Controls.Add(Bt6, 3, 3);
            TableLayoutButtons.Controls.Add(Bt9, 3, 2);
            TableLayoutButtons.Controls.Add(Bt8, 2, 2);
            TableLayoutButtons.Controls.Add(Bt7, 1, 2);
            TableLayoutButtons.Controls.Add(btAdd, 4, 5);
            TableLayoutButtons.Controls.Add(btSub, 4, 4);
            TableLayoutButtons.Controls.Add(btMul, 4, 3);
            TableLayoutButtons.Controls.Add(btDelete, 1, 0);
            TableLayoutButtons.Controls.Add(btClear, 3, 0);
            TableLayoutButtons.Controls.Add(btAnswer, 5, 0);
            TableLayoutButtons.Controls.Add(btFactorial, 5, 1);
            TableLayoutButtons.Controls.Add(btBracketClose, 2, 1);
            TableLayoutButtons.Controls.Add(btBracketOpen, 1, 1);
            TableLayoutButtons.Controls.Add(btDiv, 4, 2);
            TableLayoutButtons.Controls.Add(btPow, 3, 1);
            TableLayoutButtons.Controls.Add(btModulo, 5, 5);
            TableLayoutButtons.Controls.Add(btSqrt, 4, 1);
            TableLayoutButtons.Controls.Add(btNegate, 5, 2);
            TableLayoutButtons.Controls.Add(btReciprocal, 5, 3);
            TableLayoutButtons.Controls.Add(btPi, 5, 4);
            TableLayoutButtons.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutButtons.Location = new Point(3, 164);
            TableLayoutButtons.Margin = new Padding(0);
            TableLayoutButtons.Name = "TableLayoutButtons";
            TableLayoutButtons.RowCount = 6;
            TableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            TableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            TableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            TableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            TableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            TableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            TableLayoutButtons.Size = new Size(427, 381);
            TableLayoutButtons.TabIndex = 5;
            // 
            // BtF
            // 
            BtF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtF.AutoSize = true;
            BtF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtF.Cursor = Cursors.Hand;
            BtF.Enabled = false;
            BtF.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BtF.FlatAppearance.BorderSize = 2;
            BtF.FlatStyle = FlatStyle.Flat;
            BtF.Location = new Point(3, 318);
            BtF.Name = "BtF";
            BtF.Size = new Size(65, 60);
            BtF.TabIndex = 9;
            BtF.TabStop = false;
            BtF.Text = "F";
            BtF.UseVisualStyleBackColor = false;
            BtF.SizeChanged += ObjectHelper_Changed;
            BtF.Click += BtNumeric_Click;
            // 
            // BtE
            // 
            BtE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtE.AutoSize = true;
            BtE.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtE.Cursor = Cursors.Hand;
            BtE.Enabled = false;
            BtE.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BtE.FlatAppearance.BorderSize = 2;
            BtE.FlatStyle = FlatStyle.Flat;
            BtE.Location = new Point(3, 255);
            BtE.Name = "BtE";
            BtE.Size = new Size(65, 57);
            BtE.TabIndex = 8;
            BtE.TabStop = false;
            BtE.Text = "E";
            BtE.UseVisualStyleBackColor = false;
            BtE.SizeChanged += ObjectHelper_Changed;
            BtE.Click += BtNumeric_Click;
            // 
            // BtD
            // 
            BtD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtD.AutoSize = true;
            BtD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtD.Cursor = Cursors.Hand;
            BtD.Enabled = false;
            BtD.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BtD.FlatAppearance.BorderSize = 2;
            BtD.FlatStyle = FlatStyle.Flat;
            BtD.Location = new Point(3, 192);
            BtD.Name = "BtD";
            BtD.Size = new Size(65, 57);
            BtD.TabIndex = 7;
            BtD.TabStop = false;
            BtD.Text = "D";
            BtD.UseVisualStyleBackColor = false;
            BtD.SizeChanged += ObjectHelper_Changed;
            BtD.Click += BtNumeric_Click;
            // 
            // BtC
            // 
            BtC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtC.AutoSize = true;
            BtC.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtC.Cursor = Cursors.Hand;
            BtC.Enabled = false;
            BtC.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BtC.FlatAppearance.BorderSize = 2;
            BtC.FlatStyle = FlatStyle.Flat;
            BtC.Location = new Point(3, 129);
            BtC.Name = "BtC";
            BtC.Size = new Size(65, 57);
            BtC.TabIndex = 6;
            BtC.TabStop = false;
            BtC.Text = "C";
            BtC.UseVisualStyleBackColor = false;
            BtC.SizeChanged += ObjectHelper_Changed;
            BtC.Click += BtNumeric_Click;
            // 
            // BtB
            // 
            BtB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtB.AutoSize = true;
            BtB.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtB.Cursor = Cursors.Hand;
            BtB.Enabled = false;
            BtB.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BtB.FlatAppearance.BorderSize = 2;
            BtB.FlatStyle = FlatStyle.Flat;
            BtB.Location = new Point(3, 66);
            BtB.Name = "BtB";
            BtB.Size = new Size(65, 57);
            BtB.TabIndex = 5;
            BtB.TabStop = false;
            BtB.Text = "B";
            BtB.UseVisualStyleBackColor = false;
            BtB.SizeChanged += ObjectHelper_Changed;
            BtB.Click += BtNumeric_Click;
            // 
            // BtA
            // 
            BtA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtA.AutoSize = true;
            BtA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtA.Cursor = Cursors.Hand;
            BtA.Enabled = false;
            BtA.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BtA.FlatAppearance.BorderSize = 2;
            BtA.FlatStyle = FlatStyle.Flat;
            BtA.Location = new Point(3, 3);
            BtA.Name = "BtA";
            BtA.Size = new Size(65, 57);
            BtA.TabIndex = 10;
            BtA.TabStop = false;
            BtA.Text = "A";
            BtA.UseVisualStyleBackColor = false;
            BtA.SizeChanged += ObjectHelper_Changed;
            BtA.Click += BtNumeric_Click;
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
            btAnswer.ForeColor = SystemColors.WindowFrame;
            btAnswer.Location = new Point(358, 3);
            btAnswer.Name = "btAnswer";
            btAnswer.Size = new Size(66, 57);
            btAnswer.TabIndex = 3;
            btAnswer.TabStop = false;
            btAnswer.Text = "📋";
            btAnswer.UseVisualStyleBackColor = false;
            btAnswer.SizeChanged += Object_Changed;
            btAnswer.Click += BtCopy_Click;
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
            btFactorial.ForeColor = SystemColors.WindowFrame;
            btFactorial.Location = new Point(358, 66);
            btFactorial.Name = "btFactorial";
            btFactorial.Size = new Size(66, 57);
            btFactorial.TabIndex = 4;
            btFactorial.TabStop = false;
            btFactorial.Text = "n!";
            btFactorial.UseVisualStyleBackColor = false;
            btFactorial.SizeChanged += ObjectHelper_Changed;
            btFactorial.Click += BtFactorial_Click;
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
            btBracketClose.ForeColor = SystemColors.WindowFrame;
            btBracketClose.Location = new Point(145, 66);
            btBracketClose.Name = "btBracketClose";
            btBracketClose.Size = new Size(65, 57);
            btBracketClose.TabIndex = 12;
            btBracketClose.TabStop = false;
            btBracketClose.Text = ")";
            btBracketClose.UseVisualStyleBackColor = false;
            btBracketClose.SizeChanged += ObjectHelper_Changed;
            btBracketClose.Click += BtOperatorRight_Click;
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
            btBracketOpen.ForeColor = SystemColors.WindowFrame;
            btBracketOpen.Location = new Point(74, 66);
            btBracketOpen.Name = "btBracketOpen";
            btBracketOpen.Size = new Size(65, 57);
            btBracketOpen.TabIndex = 11;
            btBracketOpen.TabStop = false;
            btBracketOpen.Text = "(";
            btBracketOpen.UseVisualStyleBackColor = false;
            btBracketOpen.SizeChanged += ObjectHelper_Changed;
            btBracketOpen.Click += BtOperatorRight_Click;
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
            btPow.ForeColor = SystemColors.WindowFrame;
            btPow.Location = new Point(216, 66);
            btPow.Name = "btPow";
            btPow.Size = new Size(65, 57);
            btPow.TabIndex = 4;
            btPow.TabStop = false;
            btPow.Text = "xʸ";
            btPow.UseVisualStyleBackColor = false;
            btPow.SizeChanged += ObjectHelper_Changed;
            btPow.Click += BtPow_Click;
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
            btModulo.ForeColor = SystemColors.WindowFrame;
            btModulo.Location = new Point(358, 318);
            btModulo.Name = "btModulo";
            btModulo.Size = new Size(66, 60);
            btModulo.TabIndex = 13;
            btModulo.TabStop = false;
            btModulo.Text = "%";
            btModulo.UseVisualStyleBackColor = false;
            btModulo.SizeChanged += ObjectHelper_Changed;
            btModulo.Click += BtOperatorRight_Click;
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
            btSqrt.ForeColor = SystemColors.WindowFrame;
            btSqrt.Location = new Point(287, 66);
            btSqrt.Name = "btSqrt";
            btSqrt.Size = new Size(65, 57);
            btSqrt.TabIndex = 4;
            btSqrt.TabStop = false;
            btSqrt.Text = "√";
            btSqrt.UseVisualStyleBackColor = false;
            btSqrt.SizeChanged += ObjectHelper_Changed;
            btSqrt.Click += BtOperatorLeft_Click;
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
            btNegate.ForeColor = SystemColors.WindowFrame;
            btNegate.Location = new Point(358, 129);
            btNegate.Name = "btNegate";
            btNegate.Size = new Size(66, 57);
            btNegate.TabIndex = 14;
            btNegate.TabStop = false;
            btNegate.Text = "±";
            btNegate.UseVisualStyleBackColor = false;
            btNegate.SizeChanged += ObjectHelper_Changed;
            btNegate.Click += BtNegate_Click;
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
            btReciprocal.ForeColor = SystemColors.WindowFrame;
            btReciprocal.Location = new Point(358, 192);
            btReciprocal.Name = "btReciprocal";
            btReciprocal.Size = new Size(66, 57);
            btReciprocal.TabIndex = 15;
            btReciprocal.TabStop = false;
            btReciprocal.Text = "1/n";
            btReciprocal.UseVisualStyleBackColor = false;
            btReciprocal.SizeChanged += ObjectHelper_Changed;
            btReciprocal.Click += BtReciprocal_Click;
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
            btPi.ForeColor = SystemColors.WindowFrame;
            btPi.Location = new Point(358, 255);
            btPi.Name = "btPi";
            btPi.Size = new Size(66, 57);
            btPi.TabIndex = 4;
            btPi.TabStop = false;
            btPi.Text = "π";
            btPi.UseVisualStyleBackColor = false;
            btPi.SizeChanged += ObjectHelper_Changed;
            btPi.Click += BtOperatorRight_Click;
            // 
            // TableLayoutMain
            // 
            TableLayoutMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutMain.ColumnCount = 1;
            TableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutMain.Controls.Add(tableLayoutBase, 0, 2);
            TableLayoutMain.Controls.Add(TableLayoutButtons, 0, 3);
            TableLayoutMain.Controls.Add(TbEval, 0, 0);
            TableLayoutMain.Controls.Add(tableLayoutInput, 0, 1);
            TableLayoutMain.Dock = DockStyle.Fill;
            TableLayoutMain.Location = new Point(0, 24);
            TableLayoutMain.Margin = new Padding(0);
            TableLayoutMain.MinimumSize = new Size(200, 300);
            TableLayoutMain.Name = "TableLayoutMain";
            TableLayoutMain.Padding = new Padding(3);
            TableLayoutMain.RowCount = 4;
            TableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            TableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            TableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            TableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutMain.Size = new Size(433, 548);
            TableLayoutMain.TabIndex = 6;
            // 
            // tableLayoutBase
            // 
            tableLayoutBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutBase.ColumnCount = 2;
            tableLayoutBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0023861F));
            tableLayoutBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.99761F));
            tableLayoutBase.Controls.Add(BtBase2, 1, 3);
            tableLayoutBase.Controls.Add(BtBase8, 1, 2);
            tableLayoutBase.Controls.Add(BtBase10, 1, 1);
            tableLayoutBase.Controls.Add(rbBase2, 0, 3);
            tableLayoutBase.Controls.Add(rbBase8, 0, 2);
            tableLayoutBase.Controls.Add(RbBase10, 0, 1);
            tableLayoutBase.Controls.Add(rbBase16, 0, 0);
            tableLayoutBase.Controls.Add(BtBase16, 1, 0);
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
            // BtBase2
            // 
            BtBase2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtBase2.Cursor = Cursors.IBeam;
            BtBase2.FlatAppearance.BorderSize = 0;
            BtBase2.FlatStyle = FlatStyle.Flat;
            BtBase2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtBase2.Location = new Point(89, 69);
            BtBase2.Margin = new Padding(0);
            BtBase2.Name = "BtBase2";
            BtBase2.Size = new Size(338, 25);
            BtBase2.TabIndex = 15;
            BtBase2.TabStop = false;
            BtBase2.Text = "0";
            BtBase2.TextAlign = ContentAlignment.MiddleLeft;
            BtBase2.UseVisualStyleBackColor = true;
            BtBase2.SizeChanged += Object_Changed;
            BtBase2.Click += BtBase_Click;
            // 
            // BtBase8
            // 
            BtBase8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtBase8.Cursor = Cursors.IBeam;
            BtBase8.FlatAppearance.BorderSize = 0;
            BtBase8.FlatStyle = FlatStyle.Flat;
            BtBase8.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtBase8.Location = new Point(89, 46);
            BtBase8.Margin = new Padding(0);
            BtBase8.Name = "BtBase8";
            BtBase8.Size = new Size(338, 23);
            BtBase8.TabIndex = 14;
            BtBase8.TabStop = false;
            BtBase8.Text = "0";
            BtBase8.TextAlign = ContentAlignment.MiddleLeft;
            BtBase8.UseVisualStyleBackColor = true;
            BtBase8.SizeChanged += Object_Changed;
            BtBase8.Click += BtBase_Click;
            // 
            // BtBase10
            // 
            BtBase10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtBase10.Cursor = Cursors.IBeam;
            BtBase10.FlatAppearance.BorderSize = 0;
            BtBase10.FlatStyle = FlatStyle.Flat;
            BtBase10.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtBase10.Location = new Point(89, 23);
            BtBase10.Margin = new Padding(0);
            BtBase10.Name = "BtBase10";
            BtBase10.Size = new Size(338, 23);
            BtBase10.TabIndex = 13;
            BtBase10.TabStop = false;
            BtBase10.Text = "0";
            BtBase10.TextAlign = ContentAlignment.MiddleLeft;
            BtBase10.UseVisualStyleBackColor = true;
            BtBase10.SizeChanged += Object_Changed;
            BtBase10.Click += BtBase_Click;
            // 
            // rbBase2
            // 
            rbBase2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbBase2.AutoSize = true;
            rbBase2.Cursor = Cursors.Hand;
            rbBase2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbBase2.Location = new Point(3, 72);
            rbBase2.Name = "rbBase2";
            rbBase2.Size = new Size(83, 19);
            rbBase2.TabIndex = 11;
            rbBase2.Text = "Bin  (2)";
            rbBase2.TextAlign = ContentAlignment.MiddleCenter;
            rbBase2.UseVisualStyleBackColor = true;
            rbBase2.CheckedChanged += BaseUpdate;
            // 
            // rbBase8
            // 
            rbBase8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbBase8.AutoSize = true;
            rbBase8.Cursor = Cursors.Hand;
            rbBase8.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbBase8.Location = new Point(3, 49);
            rbBase8.Name = "rbBase8";
            rbBase8.Size = new Size(83, 17);
            rbBase8.TabIndex = 11;
            rbBase8.Text = "Oct  (8)";
            rbBase8.TextAlign = ContentAlignment.MiddleCenter;
            rbBase8.UseVisualStyleBackColor = true;
            rbBase8.CheckedChanged += BaseUpdate;
            // 
            // RbBase10
            // 
            RbBase10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RbBase10.AutoSize = true;
            RbBase10.Checked = true;
            RbBase10.Cursor = Cursors.Hand;
            RbBase10.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RbBase10.Location = new Point(3, 26);
            RbBase10.Name = "RbBase10";
            RbBase10.Size = new Size(83, 17);
            RbBase10.TabIndex = 12;
            RbBase10.TabStop = true;
            RbBase10.Text = "Dec (10)";
            RbBase10.TextAlign = ContentAlignment.MiddleCenter;
            RbBase10.UseVisualStyleBackColor = true;
            RbBase10.CheckedChanged += BaseUpdate;
            // 
            // rbBase16
            // 
            rbBase16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbBase16.AutoSize = true;
            rbBase16.Cursor = Cursors.Hand;
            rbBase16.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbBase16.Location = new Point(3, 3);
            rbBase16.Name = "rbBase16";
            rbBase16.Size = new Size(83, 17);
            rbBase16.TabIndex = 0;
            rbBase16.Text = "Hex (16)";
            rbBase16.TextAlign = ContentAlignment.MiddleCenter;
            rbBase16.UseVisualStyleBackColor = true;
            rbBase16.CheckedChanged += BaseUpdate;
            // 
            // BtBase16
            // 
            BtBase16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtBase16.Cursor = Cursors.IBeam;
            BtBase16.FlatAppearance.BorderSize = 0;
            BtBase16.FlatStyle = FlatStyle.Flat;
            BtBase16.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtBase16.Location = new Point(89, 0);
            BtBase16.Margin = new Padding(0);
            BtBase16.Name = "BtBase16";
            BtBase16.Size = new Size(338, 23);
            BtBase16.TabIndex = 12;
            BtBase16.TabStop = false;
            BtBase16.Text = "0";
            BtBase16.TextAlign = ContentAlignment.MiddleLeft;
            BtBase16.UseVisualStyleBackColor = true;
            BtBase16.SizeChanged += Object_Changed;
            BtBase16.Click += BtBase_Click;
            // 
            // TbEval
            // 
            TbEval.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TbEval.BorderStyle = BorderStyle.None;
            TbEval.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TbEval.Location = new Point(6, 6);
            TbEval.Margin = new Padding(3, 3, 3, 0);
            TbEval.Name = "TbEval";
            TbEval.ReadOnly = true;
            TbEval.ScrollBars = RichTextBoxScrollBars.None;
            TbEval.Size = new Size(421, 24);
            TbEval.TabIndex = 13;
            TbEval.TabStop = false;
            TbEval.Text = "";
            TbEval.SizeChanged += Object_Changed;
            TbEval.TextChanged += Object_Changed;
            TbEval.Enter += TbDeselect_Enter;
            // 
            // tableLayoutInput
            // 
            tableLayoutInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutInput.ColumnCount = 2;
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutInput.Controls.Add(TbInput, 1, 0);
            tableLayoutInput.Controls.Add(TbSymbol, 0, 0);
            tableLayoutInput.Location = new Point(6, 33);
            tableLayoutInput.Name = "tableLayoutInput";
            tableLayoutInput.RowCount = 1;
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutInput.Size = new Size(421, 34);
            tableLayoutInput.TabIndex = 18;
            // 
            // TbInput
            // 
            TbInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TbInput.BorderStyle = BorderStyle.None;
            TbInput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TbInput.Location = new Point(42, 0);
            TbInput.Margin = new Padding(0, 0, 3, 3);
            TbInput.Name = "TbInput";
            TbInput.ReadOnly = true;
            TbInput.ScrollBars = RichTextBoxScrollBars.None;
            TbInput.Size = new Size(376, 31);
            TbInput.TabIndex = 13;
            TbInput.Text = "";
            TbInput.SizeChanged += Object_Changed;
            TbInput.TextChanged += Object_Changed;
            TbInput.Enter += TbDeselect_Enter;
            // 
            // TbSymbol
            // 
            TbSymbol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TbSymbol.AutoSize = true;
            TbSymbol.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TbSymbol.Location = new Point(3, 0);
            TbSymbol.Margin = new Padding(3, 0, 0, 3);
            TbSymbol.Name = "TbSymbol";
            TbSymbol.Size = new Size(39, 31);
            TbSymbol.TabIndex = 14;
            TbSymbol.Text = ">";
            TbSymbol.TextAlign = ContentAlignment.MiddleLeft;
            TbSymbol.SizeChanged += Object_Changed;
            TbSymbol.TextChanged += Object_Changed;
            // 
            // Interface
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(433, 572);
            Controls.Add(TableLayoutMain);
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
            TableLayoutButtons.ResumeLayout(false);
            TableLayoutButtons.PerformLayout();
            TableLayoutMain.ResumeLayout(false);
            TableLayoutMain.PerformLayout();
            tableLayoutBase.ResumeLayout(false);
            tableLayoutBase.PerformLayout();
            tableLayoutInput.ResumeLayout(false);
            tableLayoutInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private TableLayoutPanel TableLayoutButtons;
        private ToolStripMenuItem StripMenuEdit;
        private ToolStripMenuItem StripMenuMode;
        private ToolStripMenuItem MenuModeSim;
        private ToolStripMenuItem MenuModeAdv;
        private ToolStripMenuItem MenuEditTopmost;
        private ToolStripMenuItem MenuEditDarkmode;
        private Button Bt9;
        private Button btDelete;
        private Button Bt0;
        private Button Bt6;
        private Button Bt2;
        private Button Bt3;
        private Button Bt5;
        private Button btAdd;
        private Button Bt8;
        private Button btDiv;
        private Button BtCom;
        private Button btClear;
        private Button Bt1;
        private Button btMul;
        private Button Bt4;
        private Button Bt7;
        private Button btCalc;
        private Button btSub;
        private Button btPi;
        private Button btFactorial;
        private Button btSqrt;
        private Button btPow;
        private Button btAnswer;
        private TableLayoutPanel TableLayoutMain;
        private ToolStripMenuItem StripMenuVersion;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem MenuEditDebug;
        private ToolStripMenuItem MenuModePro;
        private Button BtF;
        private Button BtE;
        private Button BtD;
        private Button BtC;
        private Button BtB;
        private Button BtA;
        private Button btBracketOpen;
        private Button btBracketClose;
        private Button btModulo;
        private Button btNegate;
        private Button btReciprocal;
        private RichTextBox TbEval;
        private ToolStripMenuItem StripMenuInfo;
        private TableLayoutPanel tableLayoutBase;
        private Button BtBase10;
        private RadioButton rbBase2;
        private RadioButton rbBase8;
        private RadioButton RbBase10;
        private RadioButton rbBase16;
        private Button BtBase16;
        private Button BtBase2;
        private Button BtBase8;
        private TableLayoutPanel tableLayoutInput;
        private RichTextBox TbInput;
        private Label TbSymbol;
    }
}