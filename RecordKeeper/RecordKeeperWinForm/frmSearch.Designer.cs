namespace RecordKeeperWinForm
{
    partial class frmSearch
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
            tblMain = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnSearch = new Button();
            gPresident = new DataGridView();
            btnNew = new Button();
            tblMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gPresident).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(tableLayoutPanel1, 0, 0);
            tblMain.Controls.Add(gPresident, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(815, 642);
            tblMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblLastName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel1.Controls.Add(btnNew, 3, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(468, 46);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Left;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(3, 8);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(112, 30);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left;
            txtLastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(121, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(129, 35);
            txtLastName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(256, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // gPresident
            // 
            gPresident.AllowUserToOrderColumns = true;
            gPresident.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gPresident.Dock = DockStyle.Fill;
            gPresident.Location = new Point(3, 55);
            gPresident.Name = "gPresident";
            gPresident.Size = new Size(809, 584);
            gPresident.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.AutoSize = true;
            btnNew.Dock = DockStyle.Fill;
            btnNew.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(391, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(74, 40);
            btnNew.TabIndex = 3;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 642);
            Controls.Add(tblMain);
            Name = "frmSearch";
            Text = "President Search";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gPresident).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnSearch;
        private DataGridView gPresident;
        private Button btnNew;
    }
}