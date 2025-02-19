﻿using System.Data;
using System.Diagnostics;
using CPUFramework;

namespace RecordKeeperWinForm
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();

            btnSearch.Click += BtnSearch_Click;
            gPresident.CellDoubleClick += GPresident_CellDoubleClick;
            FormatGrid();
        }

      

        private void SearchForPresident(string lastname)
        {
            string sql = "select PresidentId, Num, LastName, FirstName from president p where p.lastname like '%" + lastname + "%' ";
            
            DataTable dt = SQLUtility.GetDataTable(sql);
            gPresident.DataSource = dt;
            gPresident.Columns["PresidentId"].Visible= false;

            //run the sql
            //get the data table
            //bind the grid
        }

        private void ShowPresidentForm(int rowIndex)
        {
            int id = (int)gPresident.Rows[rowIndex].Cells["PresidentId"].Value;
            frmPresident frm = new frmPresident();
            frm.ShowForm(id);
        }

        private  void FormatGrid()
        {
            gPresident.AllowUserToAddRows = false;
            gPresident.ReadOnly = true;
            gPresident.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.AllCells;
            gPresident.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
        } 
        private void GPresident_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        { 
            ShowPresidentForm(e.RowIndex);
        }
       
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForPresident(txtLastName.Text);
        }

        

    }
}
