namespace RecordKeeperWinForm
{
    partial class frmDataMaintence
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
            btnSave = new Button();
            gData = new DataGridView();
            pnlOptionButtons = new FlowLayoutPanel();
            optCountry = new RadioButton();
            optCity = new RadioButton();
            optOlympicMedal = new RadioButton();
            optSeason = new RadioButton();
            optSport = new RadioButton();
            optSportSubcategory = new RadioButton();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            pnlOptionButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.375F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.625F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(gData, 1, 1);
            tblMain.Controls.Add(pnlOptionButtons, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 4, 4, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(4, 4);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(68, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(150, 46);
            gData.Name = "gData";
            gData.Size = new Size(876, 581);
            gData.TabIndex = 1;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.Controls.Add(optCountry);
            pnlOptionButtons.Controls.Add(optCity);
            pnlOptionButtons.Controls.Add(optOlympicMedal);
            pnlOptionButtons.Controls.Add(optSeason);
            pnlOptionButtons.Controls.Add(optSport);
            pnlOptionButtons.Controls.Add(optSportSubcategory);
            pnlOptionButtons.Dock = DockStyle.Fill;
            pnlOptionButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptionButtons.Location = new Point(3, 46);
            pnlOptionButtons.Name = "pnlOptionButtons";
            pnlOptionButtons.Size = new Size(141, 581);
            pnlOptionButtons.TabIndex = 2;
            // 
            // optCountry
            // 
            optCountry.AutoSize = true;
            optCountry.Location = new Point(3, 3);
            optCountry.Name = "optCountry";
            optCountry.Size = new Size(95, 25);
            optCountry.TabIndex = 0;
            optCountry.TabStop = true;
            optCountry.Text = "Countries";
            optCountry.UseVisualStyleBackColor = true;
            // 
            // optCity
            // 
            optCity.AutoSize = true;
            optCity.Location = new Point(3, 34);
            optCity.Name = "optCity";
            optCity.Size = new Size(66, 25);
            optCity.TabIndex = 1;
            optCity.TabStop = true;
            optCity.Text = "Cities";
            optCity.UseVisualStyleBackColor = true;
            // 
            // optOlympicMedal
            // 
            optOlympicMedal.AutoSize = true;
            optOlympicMedal.Location = new Point(3, 65);
            optOlympicMedal.Name = "optOlympicMedal";
            optOlympicMedal.Size = new Size(140, 25);
            optOlympicMedal.TabIndex = 2;
            optOlympicMedal.TabStop = true;
            optOlympicMedal.Text = "Olympic Medals";
            optOlympicMedal.UseVisualStyleBackColor = true;
            // 
            // optSeason
            // 
            optSeason.AutoSize = true;
            optSeason.Location = new Point(3, 96);
            optSeason.Name = "optSeason";
            optSeason.Size = new Size(85, 25);
            optSeason.TabIndex = 3;
            optSeason.TabStop = true;
            optSeason.Text = "Seasons";
            optSeason.UseVisualStyleBackColor = true;
            // 
            // optSport
            // 
            optSport.AutoSize = true;
            optSport.Location = new Point(3, 127);
            optSport.Name = "optSport";
            optSport.Size = new Size(73, 25);
            optSport.TabIndex = 4;
            optSport.TabStop = true;
            optSport.Text = "Sports";
            optSport.UseVisualStyleBackColor = true;
            // 
            // optSportSubcategory
            // 
            optSportSubcategory.AutoSize = true;
            optSportSubcategory.Location = new Point(3, 158);
            optSportSubcategory.Name = "optSportSubcategory";
            optSportSubcategory.Size = new Size(164, 25);
            optSportSubcategory.TabIndex = 5;
            optSportSubcategory.TabStop = true;
            optSportSubcategory.Text = "SportSubcategories";
            optSportSubcategory.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintence
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDataMaintence";
            Text = "DataMaintence";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            pnlOptionButtons.ResumeLayout(false);
            pnlOptionButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optCountry;
        private RadioButton optCity;
        private RadioButton optOlympicMedal;
        private RadioButton optSeason;
        private RadioButton optSport;
        private RadioButton optSportSubcategory;
    }
}