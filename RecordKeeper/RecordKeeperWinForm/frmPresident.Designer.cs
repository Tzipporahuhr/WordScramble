namespace RecordKeeperWinForm
{
    partial class frmPresident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresident));
            tblMain = new TableLayoutPanel();
            lblCaptionParty = new Label();
            lblCaptionNum = new Label();
            lblCaptionFirstName = new Label();
            lblCaptionLastName = new Label();
            lblCaptionDateBorn = new Label();
            lblCaptionDateDied = new Label();
            lblCaptionTermStart = new Label();
            lblCaptionTermEnd = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDateDied = new TextBox();
            txtTermStart = new TextBox();
            txtTermEnd = new TextBox();
            lstPartyName = new ComboBox();
            txtNum = new TextBox();
            dtpDateBorn = new DateTimePicker();
            toolStrip1 = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tblMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionParty, 0, 0);
            tblMain.Controls.Add(lblCaptionNum, 0, 1);
            tblMain.Controls.Add(lblCaptionFirstName, 0, 2);
            tblMain.Controls.Add(lblCaptionLastName, 0, 3);
            tblMain.Controls.Add(lblCaptionDateBorn, 0, 4);
            tblMain.Controls.Add(lblCaptionDateDied, 0, 5);
            tblMain.Controls.Add(lblCaptionTermStart, 0, 6);
            tblMain.Controls.Add(lblCaptionTermEnd, 0, 7);
            tblMain.Controls.Add(txtFirstName, 1, 2);
            tblMain.Controls.Add(txtLastName, 1, 3);
            tblMain.Controls.Add(txtDateDied, 1, 5);
            tblMain.Controls.Add(txtTermStart, 1, 6);
            tblMain.Controls.Add(txtTermEnd, 1, 7);
            tblMain.Controls.Add(lstPartyName, 1, 0);
            tblMain.Controls.Add(txtNum, 1, 1);
            tblMain.Controls.Add(dtpDateBorn, 1, 4);
            tblMain.Location = new Point(2, 27);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.Size = new Size(538, 528);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionParty
            // 
            lblCaptionParty.Anchor = AnchorStyles.Left;
            lblCaptionParty.AutoSize = true;
            lblCaptionParty.Location = new Point(3, 9);
            lblCaptionParty.Name = "lblCaptionParty";
            lblCaptionParty.Size = new Size(45, 21);
            lblCaptionParty.TabIndex = 0;
            lblCaptionParty.Text = "Party";
            // 
            // lblCaptionNum
            // 
            lblCaptionNum.Anchor = AnchorStyles.Left;
            lblCaptionNum.AutoSize = true;
            lblCaptionNum.Location = new Point(3, 49);
            lblCaptionNum.Name = "lblCaptionNum";
            lblCaptionNum.Size = new Size(45, 21);
            lblCaptionNum.TabIndex = 1;
            lblCaptionNum.Text = "Num";
            // 
            // lblCaptionFirstName
            // 
            lblCaptionFirstName.Anchor = AnchorStyles.Left;
            lblCaptionFirstName.AutoSize = true;
            lblCaptionFirstName.Font = new Font("Microsoft Sans Serif", 12F);
            lblCaptionFirstName.Location = new Point(3, 90);
            lblCaptionFirstName.Name = "lblCaptionFirstName";
            lblCaptionFirstName.Size = new Size(82, 20);
            lblCaptionFirstName.TabIndex = 2;
            lblCaptionFirstName.Text = "FirstName";
            // 
            // lblCaptionLastName
            // 
            lblCaptionLastName.Anchor = AnchorStyles.Left;
            lblCaptionLastName.AutoSize = true;
            lblCaptionLastName.Font = new Font("Microsoft Sans Serif", 12F);
            lblCaptionLastName.Location = new Point(3, 130);
            lblCaptionLastName.Name = "lblCaptionLastName";
            lblCaptionLastName.Size = new Size(82, 20);
            lblCaptionLastName.TabIndex = 3;
            lblCaptionLastName.Text = "LastName";
            // 
            // lblCaptionDateBorn
            // 
            lblCaptionDateBorn.Anchor = AnchorStyles.Left;
            lblCaptionDateBorn.AutoSize = true;
            lblCaptionDateBorn.Font = new Font("Microsoft Sans Serif", 12F);
            lblCaptionDateBorn.Location = new Point(3, 170);
            lblCaptionDateBorn.Name = "lblCaptionDateBorn";
            lblCaptionDateBorn.Size = new Size(82, 20);
            lblCaptionDateBorn.TabIndex = 4;
            lblCaptionDateBorn.Text = "Date Born";
            // 
            // lblCaptionDateDied
            // 
            lblCaptionDateDied.Anchor = AnchorStyles.Left;
            lblCaptionDateDied.AutoSize = true;
            lblCaptionDateDied.Location = new Point(3, 209);
            lblCaptionDateDied.Name = "lblCaptionDateDied";
            lblCaptionDateDied.Size = new Size(78, 21);
            lblCaptionDateDied.TabIndex = 5;
            lblCaptionDateDied.Text = "Date Died";
            // 
            // lblCaptionTermStart
            // 
            lblCaptionTermStart.Anchor = AnchorStyles.Left;
            lblCaptionTermStart.AutoSize = true;
            lblCaptionTermStart.Location = new Point(3, 249);
            lblCaptionTermStart.Name = "lblCaptionTermStart";
            lblCaptionTermStart.Size = new Size(80, 21);
            lblCaptionTermStart.TabIndex = 6;
            lblCaptionTermStart.Text = "Term Start";
            // 
            // lblCaptionTermEnd
            // 
            lblCaptionTermEnd.AutoSize = true;
            lblCaptionTermEnd.Location = new Point(3, 287);
            lblCaptionTermEnd.Margin = new Padding(3, 7, 3, 0);
            lblCaptionTermEnd.Name = "lblCaptionTermEnd";
            lblCaptionTermEnd.Size = new Size(74, 21);
            lblCaptionTermEnd.TabIndex = 7;
            lblCaptionTermEnd.Text = "Term End";
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(91, 83);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(444, 29);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(91, 123);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(444, 29);
            txtLastName.TabIndex = 11;
            // 
            // txtDateDied
            // 
            txtDateDied.Dock = DockStyle.Fill;
            txtDateDied.Location = new Point(91, 203);
            txtDateDied.Name = "txtDateDied";
            txtDateDied.Size = new Size(444, 29);
            txtDateDied.TabIndex = 13;
            // 
            // txtTermStart
            // 
            txtTermStart.Dock = DockStyle.Fill;
            txtTermStart.Location = new Point(91, 243);
            txtTermStart.Name = "txtTermStart";
            txtTermStart.Size = new Size(444, 29);
            txtTermStart.TabIndex = 14;
            // 
            // txtTermEnd
            // 
            txtTermEnd.Dock = DockStyle.Fill;
            txtTermEnd.Location = new Point(91, 283);
            txtTermEnd.Name = "txtTermEnd";
            txtTermEnd.Size = new Size(444, 29);
            txtTermEnd.TabIndex = 15;
            // 
            // lstPartyName
            // 
            lstPartyName.FormattingEnabled = true;
            lstPartyName.Location = new Point(91, 3);
            lstPartyName.Name = "lstPartyName";
            lstPartyName.Size = new Size(199, 29);
            lstPartyName.TabIndex = 16;
            // 
            // txtNum
            // 
            txtNum.Dock = DockStyle.Fill;
            txtNum.Location = new Point(91, 43);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(444, 29);
            txtNum.TabIndex = 17;
            // 
            // dtpDateBorn
            // 
            dtpDateBorn.Format = DateTimePickerFormat.Short;
            dtpDateBorn.Location = new Point(91, 163);
            dtpDateBorn.Name = "dtpDateBorn";
            dtpDateBorn.Size = new Size(199, 29);
            dtpDateBorn.TabIndex = 18;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(534, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 25);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(58, 25);
            btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // frmPresident
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 549);
            Controls.Add(toolStrip1);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmPresident";
            Text = "President";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionParty;
        private Label lblCaptionNum;
        private Label lblCaptionFirstName;
        private Label lblCaptionLastName;
        private Label lblCaptionDateBorn;
        private Label lblCaptionDateDied;
        private Label lblCaptionTermStart;
        private Label lblCaptionTermEnd;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDateDied;
        private TextBox txtTermStart;
        private TextBox txtTermEnd;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ComboBox lstPartyName;
        private TextBox txtNum;
        private DateTimePicker dtpDateBorn;
    }
}