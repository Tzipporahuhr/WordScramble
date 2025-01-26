using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordKeeperWinForm
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();

            btnSearch.Click += BtnSearch_Click;
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
           
        }

        private void SearchForPresident(string lastname)
        {
            string sql = "select * from president p where p.lastname like '%" + lastname + "%' ";
            Debug.Print(sql);

            //run the sql
            //get the data table
            //bind the grid
        }

        private string GetConnectionString()
        {
            var s = "Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true";
            

            return s;
        }

        private DataTable GetDataTable(string sqlstatement)
        {
            DataTable dt = new();
            SqlConnection conn = new();
            conn.ConnectionString = GetConnectionString();
            conn.Open();
             
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement; ;
            var dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

    }
}
