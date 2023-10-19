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
            MenuModeSimple = new ToolStripMenuItem();
            MenuModeAdvanced = new ToolStripMenuItem();
            MenuModeDebug = new ToolStripMenuItem();
            StripMenuEdit = new ToolStripMenuItem();
            MenuEditTopmost = new ToolStripMenuItem();
            MenuEditDarkmode = new ToolStripMenuItem();
            StripMenuAbout = new ToolStripMenuItem();
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
            btPercent = new Button();
            btSqrt4 = new Button();
            btSqrt3 = new Button();
            btSqrt2 = new Button();
            btCopy = new Button();
            btNegate = new Button();
            btBinary = new Button();
            btHex = new Button();
            btDecimal = new Button();
            txtCalc = new RichTextBox();
            tableLayoutMain = new TableLayoutPanel();
            menuStrip.SuspendLayout();
            tableLayoutButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { StripMenuMode, StripMenuEdit, StripMenuAbout });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(254, 24);
            menuStrip.TabIndex = 1;
            // 
            // StripMenuMode
            // 
            StripMenuMode.DropDownItems.AddRange(new ToolStripItem[] { MenuModeSimple, MenuModeAdvanced, MenuModeDebug });
            StripMenuMode.Name = "StripMenuMode";
            StripMenuMode.Size = new Size(50, 20);
            StripMenuMode.Text = "Mode";
            // 
            // MenuModeSimple
            // 
            MenuModeSimple.Checked = true;
            MenuModeSimple.CheckState = CheckState.Checked;
            MenuModeSimple.Name = "MenuModeSimple";
            MenuModeSimple.ShortcutKeys = Keys.F1;
            MenuModeSimple.Size = new Size(146, 22);
            MenuModeSimple.Text = "Simple";
            MenuModeSimple.Click += MenuViewSimple_Click;
            // 
            // MenuModeAdvanced
            // 
            MenuModeAdvanced.Name = "MenuModeAdvanced";
            MenuModeAdvanced.ShortcutKeys = Keys.F2;
            MenuModeAdvanced.Size = new Size(146, 22);
            MenuModeAdvanced.Text = "Advanced";
            MenuModeAdvanced.Click += MenuViewAdvanced_Click;
            // 
            // MenuModeDebug
            // 
            MenuModeDebug.Name = "MenuModeDebug";
            MenuModeDebug.ShortcutKeys = Keys.F3;
            MenuModeDebug.Size = new Size(146, 22);
            MenuModeDebug.Text = "Debug";
            MenuModeDebug.Click += MenuViewDebug_Click;
            // 
            // StripMenuEdit
            // 
            StripMenuEdit.DropDownItems.AddRange(new ToolStripItem[] { MenuEditTopmost, MenuEditDarkmode });
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
            MenuEditTopmost.ShortcutKeys = Keys.Control | Keys.T;
            MenuEditTopmost.Size = new Size(192, 22);
            MenuEditTopmost.Text = "Always on Top";
            MenuEditTopmost.Click += MenuTopMost_Click;
            // 
            // MenuEditDarkmode
            // 
            MenuEditDarkmode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuEditDarkmode.Name = "MenuEditDarkmode";
            MenuEditDarkmode.ShortcutKeys = Keys.Control | Keys.D;
            MenuEditDarkmode.Size = new Size(192, 22);
            MenuEditDarkmode.Text = "Darkmode";
            MenuEditDarkmode.Click += MenuDarkmode_Click;
            // 
            // StripMenuAbout
            // 
            StripMenuAbout.Name = "StripMenuAbout";
            StripMenuAbout.Size = new Size(52, 20);
            StripMenuAbout.Text = "About";
            StripMenuAbout.Click += StripMenuAbout_Click;
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
            bt9.Location = new Point(85, 45);
            bt9.Name = "bt9";
            bt9.Size = new Size(35, 36);
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
            btDelete.Location = new Point(3, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(76, 36);
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
            bt0.Location = new Point(44, 171);
            bt0.Name = "bt0";
            bt0.Size = new Size(35, 40);
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
            bt6.Location = new Point(85, 87);
            bt6.Name = "bt6";
            bt6.Size = new Size(35, 36);
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
            bt2.Location = new Point(44, 129);
            bt2.Name = "bt2";
            bt2.Size = new Size(35, 36);
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
            bt3.Location = new Point(85, 129);
            bt3.Name = "bt3";
            bt3.Size = new Size(35, 36);
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
            bt5.Location = new Point(44, 87);
            bt5.Name = "bt5";
            bt5.Size = new Size(35, 36);
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
            btAdd.Location = new Point(126, 171);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(35, 40);
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
            bt8.Location = new Point(44, 45);
            bt8.Name = "bt8";
            bt8.Size = new Size(35, 36);
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
            btDiv.Location = new Point(126, 45);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(35, 36);
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
            btCom.Location = new Point(3, 171);
            btCom.Name = "btCom";
            btCom.Size = new Size(35, 40);
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
            btClear.Location = new Point(85, 3);
            btClear.Name = "btClear";
            btClear.Size = new Size(76, 36);
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
            bt1.Location = new Point(3, 129);
            bt1.Name = "bt1";
            bt1.Size = new Size(35, 36);
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
            btMul.Location = new Point(126, 87);
            btMul.Name = "btMul";
            btMul.Size = new Size(35, 36);
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
            bt4.Location = new Point(3, 87);
            bt4.Name = "bt4";
            bt4.Size = new Size(35, 36);
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
            bt7.Location = new Point(3, 45);
            bt7.Name = "bt7";
            bt7.Size = new Size(35, 36);
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
            btCalc.Location = new Point(85, 171);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(35, 40);
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
            btSub.Location = new Point(126, 129);
            btSub.Name = "btSub";
            btSub.Size = new Size(35, 36);
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
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutButtons.Controls.Add(btCom, 0, 4);
            tableLayoutButtons.Controls.Add(bt0, 1, 4);
            tableLayoutButtons.Controls.Add(btCalc, 2, 4);
            tableLayoutButtons.Controls.Add(btAdd, 3, 4);
            tableLayoutButtons.Controls.Add(btSub, 3, 3);
            tableLayoutButtons.Controls.Add(bt3, 2, 3);
            tableLayoutButtons.Controls.Add(bt2, 1, 3);
            tableLayoutButtons.Controls.Add(bt1, 0, 3);
            tableLayoutButtons.Controls.Add(bt4, 0, 2);
            tableLayoutButtons.Controls.Add(bt7, 0, 1);
            tableLayoutButtons.Controls.Add(bt5, 1, 2);
            tableLayoutButtons.Controls.Add(bt6, 2, 2);
            tableLayoutButtons.Controls.Add(btMul, 3, 2);
            tableLayoutButtons.Controls.Add(btDiv, 3, 1);
            tableLayoutButtons.Controls.Add(bt9, 2, 1);
            tableLayoutButtons.Controls.Add(bt8, 1, 1);
            tableLayoutButtons.Controls.Add(btDelete, 0, 0);
            tableLayoutButtons.Controls.Add(btClear, 2, 0);
            tableLayoutButtons.Controls.Add(btPercent, 4, 1);
            tableLayoutButtons.Controls.Add(btSqrt4, 4, 4);
            tableLayoutButtons.Controls.Add(btSqrt3, 4, 3);
            tableLayoutButtons.Controls.Add(btSqrt2, 4, 2);
            tableLayoutButtons.Controls.Add(btCopy, 4, 0);
            tableLayoutButtons.Controls.Add(btNegate, 5, 1);
            tableLayoutButtons.Controls.Add(btBinary, 5, 2);
            tableLayoutButtons.Controls.Add(btHex, 5, 3);
            tableLayoutButtons.Controls.Add(btDecimal, 5, 4);
            tableLayoutButtons.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutButtons.Location = new Point(3, 55);
            tableLayoutButtons.Name = "tableLayoutButtons";
            tableLayoutButtons.RowCount = 5;
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButtons.Size = new Size(248, 214);
            tableLayoutButtons.TabIndex = 5;
            // 
            // btPercent
            // 
            btPercent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btPercent.AutoSize = true;
            btPercent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btPercent.Cursor = Cursors.Hand;
            btPercent.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btPercent.FlatAppearance.BorderSize = 2;
            btPercent.FlatStyle = FlatStyle.Flat;
            btPercent.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btPercent.ForeColor = SystemColors.WindowFrame;
            btPercent.Location = new Point(167, 45);
            btPercent.Name = "btPercent";
            btPercent.Size = new Size(35, 36);
            btPercent.TabIndex = 4;
            btPercent.TabStop = false;
            btPercent.Text = "%";
            btPercent.UseVisualStyleBackColor = false;
            btPercent.Click += btPercent_Click;
            // 
            // btSqrt4
            // 
            btSqrt4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btSqrt4.AutoSize = true;
            btSqrt4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSqrt4.Cursor = Cursors.Hand;
            btSqrt4.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btSqrt4.FlatAppearance.BorderSize = 2;
            btSqrt4.FlatStyle = FlatStyle.Flat;
            btSqrt4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSqrt4.ForeColor = SystemColors.WindowFrame;
            btSqrt4.Location = new Point(167, 171);
            btSqrt4.Name = "btSqrt4";
            btSqrt4.Size = new Size(35, 40);
            btSqrt4.TabIndex = 4;
            btSqrt4.TabStop = false;
            btSqrt4.Text = "∜";
            btSqrt4.UseVisualStyleBackColor = false;
            btSqrt4.Click += btSqrt4_Click;
            // 
            // btSqrt3
            // 
            btSqrt3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btSqrt3.AutoSize = true;
            btSqrt3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSqrt3.Cursor = Cursors.Hand;
            btSqrt3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btSqrt3.FlatAppearance.BorderSize = 2;
            btSqrt3.FlatStyle = FlatStyle.Flat;
            btSqrt3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSqrt3.ForeColor = SystemColors.WindowFrame;
            btSqrt3.Location = new Point(167, 129);
            btSqrt3.Name = "btSqrt3";
            btSqrt3.Size = new Size(35, 36);
            btSqrt3.TabIndex = 4;
            btSqrt3.TabStop = false;
            btSqrt3.Text = "∛";
            btSqrt3.UseVisualStyleBackColor = false;
            btSqrt3.Click += btSqrt3_Click;
            // 
            // btSqrt2
            // 
            btSqrt2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btSqrt2.AutoSize = true;
            btSqrt2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSqrt2.Cursor = Cursors.Hand;
            btSqrt2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btSqrt2.FlatAppearance.BorderSize = 2;
            btSqrt2.FlatStyle = FlatStyle.Flat;
            btSqrt2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSqrt2.ForeColor = SystemColors.WindowFrame;
            btSqrt2.Location = new Point(167, 87);
            btSqrt2.Name = "btSqrt2";
            btSqrt2.Size = new Size(35, 36);
            btSqrt2.TabIndex = 4;
            btSqrt2.TabStop = false;
            btSqrt2.Text = "√";
            btSqrt2.UseVisualStyleBackColor = false;
            btSqrt2.Click += btSqrt2_Click;
            // 
            // btCopy
            // 
            btCopy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btCopy.AutoSize = true;
            btCopy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutButtons.SetColumnSpan(btCopy, 2);
            btCopy.Cursor = Cursors.Hand;
            btCopy.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btCopy.FlatAppearance.BorderSize = 2;
            btCopy.FlatStyle = FlatStyle.Flat;
            btCopy.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCopy.ForeColor = SystemColors.WindowFrame;
            btCopy.Location = new Point(167, 3);
            btCopy.Name = "btCopy";
            btCopy.Size = new Size(78, 36);
            btCopy.TabIndex = 3;
            btCopy.TabStop = false;
            btCopy.Text = "Copy";
            btCopy.UseVisualStyleBackColor = false;
            btCopy.Click += btCopy_Click;
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
            btNegate.Location = new Point(208, 45);
            btNegate.Name = "btNegate";
            btNegate.Size = new Size(37, 36);
            btNegate.TabIndex = 4;
            btNegate.TabStop = false;
            btNegate.Text = "±";
            btNegate.UseVisualStyleBackColor = false;
            btNegate.Click += btNegate_Click;
            // 
            // btBinary
            // 
            btBinary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btBinary.AutoSize = true;
            btBinary.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btBinary.Cursor = Cursors.Hand;
            btBinary.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btBinary.FlatAppearance.BorderSize = 2;
            btBinary.FlatStyle = FlatStyle.Flat;
            btBinary.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btBinary.ForeColor = SystemColors.WindowFrame;
            btBinary.Location = new Point(208, 87);
            btBinary.Name = "btBinary";
            btBinary.Size = new Size(37, 36);
            btBinary.TabIndex = 4;
            btBinary.TabStop = false;
            btBinary.Text = "Bin";
            btBinary.UseVisualStyleBackColor = false;
            btBinary.Click += btBinary_Click;
            // 
            // btHex
            // 
            btHex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btHex.AutoSize = true;
            btHex.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btHex.Cursor = Cursors.Hand;
            btHex.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btHex.FlatAppearance.BorderSize = 2;
            btHex.FlatStyle = FlatStyle.Flat;
            btHex.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btHex.ForeColor = SystemColors.WindowFrame;
            btHex.Location = new Point(208, 129);
            btHex.Name = "btHex";
            btHex.Size = new Size(37, 36);
            btHex.TabIndex = 4;
            btHex.TabStop = false;
            btHex.Text = "Hex";
            btHex.UseVisualStyleBackColor = false;
            btHex.Click += btHex_Click;
            // 
            // btDecimal
            // 
            btDecimal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btDecimal.AutoSize = true;
            btDecimal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btDecimal.Cursor = Cursors.Hand;
            btDecimal.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btDecimal.FlatAppearance.BorderSize = 2;
            btDecimal.FlatStyle = FlatStyle.Flat;
            btDecimal.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btDecimal.ForeColor = SystemColors.WindowFrame;
            btDecimal.Location = new Point(208, 171);
            btDecimal.Name = "btDecimal";
            btDecimal.Size = new Size(37, 40);
            btDecimal.TabIndex = 4;
            btDecimal.TabStop = false;
            btDecimal.Text = "Dez";
            btDecimal.UseVisualStyleBackColor = false;
            btDecimal.Click += btDecimal_Click;
            // 
            // txtCalc
            // 
            txtCalc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCalc.BorderStyle = BorderStyle.None;
            txtCalc.Cursor = Cursors.IBeam;
            txtCalc.EnableAutoDragDrop = true;
            txtCalc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalc.Location = new Point(3, 3);
            txtCalc.Name = "txtCalc";
            txtCalc.ScrollBars = RichTextBoxScrollBars.None;
            txtCalc.Size = new Size(248, 46);
            txtCalc.TabIndex = 4;
            txtCalc.Text = "";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Controls.Add(txtCalc, 0, 0);
            tableLayoutMain.Controls.Add(tableLayoutButtons, 0, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 24);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 2;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1176472F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80.8823547F));
            tableLayoutMain.Size = new Size(254, 272);
            tableLayoutMain.TabIndex = 6;
            // 
            // Interface
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(254, 296);
            Controls.Add(tableLayoutMain);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(180, 335);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private TableLayoutPanel tableLayoutButtons;
        private ToolStripMenuItem StripMenuEdit;
        private ToolStripMenuItem StripMenuMode;
        private ToolStripMenuItem StripMenuAbout;
        private ToolStripMenuItem MenuModeSimple;
        private ToolStripMenuItem MenuModeAdvanced;
        private ToolStripMenuItem MenuModeDebug;
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
        private RichTextBox txtCalc;
        private Button btPercent;
        private Button btSqrt4;
        private Button btSqrt3;
        private Button btSqrt2;
        private Button btNegate;
        private Button btBinary;
        private Button btCopy;
        private Button btHex;
        private Button btDecimal;
        private TableLayoutPanel tableLayoutMain;
    }
}