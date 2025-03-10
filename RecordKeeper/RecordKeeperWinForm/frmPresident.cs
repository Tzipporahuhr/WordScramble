using System.Data;
using System.Diagnostics;
using CPUFramework;
namespace RecordKeeperWinForm;
using CPUWindowsFormFramework;
using RecordKeeperSystem;

public partial class frmPresident : Form
    {
        DataTable dtpresident;
        public frmPresident()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
         dtpresident = new DataTable();
            
        }

      

        public void ShowForm(int presidentid) 
        {
         dtpresident = President.Load(presidentid);
            if (presidentid == 0)
            {
                dtpresident.Rows.Add();
            }
        DataTable dtparties = President.GetPartyList();
            WindowsFormsUtility.SetListBinding(lstPartyName, dtparties, dtpresident, "Party");

        WindowsFormsUtility.SetControlBinding(txtNum, dtpresident);
        WindowsFormsUtility. SetControlBinding(txtLastName, dtpresident);
        WindowsFormsUtility.SetControlBinding(txtFirstName, dtpresident);
        WindowsFormsUtility.SetControlBinding(dtpDateBorn, dtpresident);
        WindowsFormsUtility.SetControlBinding(txtDateDied, dtpresident);
        WindowsFormsUtility.SetControlBinding(txtTermStart, dtpresident);
        WindowsFormsUtility.SetControlBinding(txtTermEnd, dtpresident);
            
            this.Show();
        }

        private void Delete()
        {
            President.Delete(dtpresident);
            this.Close();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
       
        
        private void Save()
        {
        President.Save(dtpresident);
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
 
