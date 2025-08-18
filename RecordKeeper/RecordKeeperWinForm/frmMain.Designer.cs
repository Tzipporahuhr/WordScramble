namespace RecordKeeperWinForm
{
    partial class frmMain
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
            mnuMain = new MenuStrip();
            mnuPresident = new ToolStripMenuItem();
            mnuSearchPresident = new ToolStripMenuItem();
            mnuNewPresident = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuWindowTile = new ToolStripMenuItem();
            mnuWindowCascade = new ToolStripMenuItem();
            mnuDataMaint = new ToolStripMenuItem();
            mnuDataMainEdit = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuPresident, mnuDataMaint, mnuWindow });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1029, 29);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuPresident
            // 
            mnuPresident.DropDownItems.AddRange(new ToolStripItem[] { mnuSearchPresident, mnuNewPresident });
            mnuPresident.Name = "mnuPresident";
            mnuPresident.Size = new Size(91, 25);
            mnuPresident.Text = " President";
            // 
            // mnuSearchPresident
            // 
            mnuSearchPresident.Name = "mnuSearchPresident";
            mnuSearchPresident.Size = new Size(181, 26);
            mnuSearchPresident.Text = "Search";
            // 
            // mnuNewPresident
            // 
            mnuNewPresident.Name = "mnuNewPresident";
            mnuNewPresident.Size = new Size(181, 26);
            mnuNewPresident.Text = "New President";
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowTile, mnuWindowCascade });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(80, 25);
            mnuWindow.Text = "&Window";
            mnuWindow.Click += mnuWindow_Click;
            // 
            // mnuWindowTile
            // 
            mnuWindowTile.Name = "mnuWindowTile";
            mnuWindowTile.Size = new Size(137, 26);
            mnuWindowTile.Text = "Tile";
            // 
            // mnuWindowCascade
            // 
            mnuWindowCascade.DoubleClickEnabled = true;
            mnuWindowCascade.Name = "mnuWindowCascade";
            mnuWindowCascade.Size = new Size(137, 26);
            mnuWindowCascade.Text = "Cascade";
            // 
            // mnuDataMaint
            // 
            mnuDataMaint.DropDownItems.AddRange(new ToolStripItem[] { mnuDataMainEdit });
            mnuDataMaint.Name = "mnuDataMaint";
            mnuDataMaint.Size = new Size(147, 25);
            mnuDataMaint.Text = "Data Maintenance";
            // 
            // mnuDataMainEdit
            // 
            mnuDataMainEdit.Name = "mnuDataMainEdit";
            mnuDataMainEdit.Size = new Size(180, 26);
            mnuDataMainEdit.Text = "Edit Data";
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.Location = new Point(0, 29);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1029, 25);
            tsMain.TabIndex = 3;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Record Keeper";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuPresident;
        private ToolStripMenuItem mnuSearchPresident;
        private ToolStripMenuItem mnuNewPresident;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
        private ToolStrip tsMain;
        private ToolStripMenuItem mnuDataMaint;
        private ToolStripMenuItem mnuDataMainEdit;
    }
}