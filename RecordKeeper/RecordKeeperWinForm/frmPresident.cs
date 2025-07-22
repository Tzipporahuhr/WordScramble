using System.Diagnostics;
using CPUFramework;
namespace RecordKeeperWinForm;
using CPUWindowsFormFramework;
using RecordKeeperSystem;

public partial class frmPresident : Form
    {
        DataTable dtpresident= new DataTable();
        BindingSource bindsource = new BindingSource();

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
        bindsource.DataSource = dtpresident;
            if (presidentid == 0)
            {
                dtpresident.Rows.Add();
            }
        // DataTable dtparties = President.GetPartyList();

        SqlCommand cmd = SQLUtility.GetSqlCommand("PartyGet");
        SQLUtility.SetParamValue(cmd, "@All", 1);
        DataTable dtparties = SQLUtility.GetDataTable(cmd);
        
        WindowsFormsUtility.SetListBinding(lstPartyName, dtparties, dtpresident, "Party");

        WindowsFormsUtility.SetControlBinding(txtNum, bindsource);
        WindowsFormsUtility. SetControlBinding(txtLastName, bindsource);
        WindowsFormsUtility.SetControlBinding(txtFirstName, bindsource);
        WindowsFormsUtility.SetControlBinding(dtpDateBorn, bindsource);
        WindowsFormsUtility.SetControlBinding(txtDateDied, bindsource);
        WindowsFormsUtility.SetControlBinding(txtTermStart, bindsource);
        WindowsFormsUtility.SetControlBinding(txtTermEnd, bindsource);
            
            this.Show();
        }
    public void SetControlBinding(Control ctrl, DataTable dt)
    {
        string propertyname = "";
        string columnname = "";
        string controlname = ctrl.Name.ToLower();

        if (controlname.StartsWith("txt")|| controlname.StartsWith("lbl"))
        {
            propertyname = "Text";
            columnname = controlname.Substring(3);
        }

        if (propertyname != ""&& columnname != "")
        {
            ctrl.DataBindings.Add(propertyname, dt, columnname, true, DataSourceUpdateMode.OnPropertyChanged);
        }


    }
    

        private void Delete()
        {
       var response= MessageBox.Show("Are you sure you want to delete this President?", "RecordKeeper", MessageBoxButtons.YesNo);
        if (response == DialogResult.No)
        {
            return;
        }
        Application.UseWaitCursor = true;
        try
        {
            President.Delete(dtpresident);
            this.Close();
        } catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "RecordKeeper");
        }
        finally
        {
            Application.UseWaitCursor= false;   
        }
        
          
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }


    //private void Save()
    //{
    //Application.UseWaitCursor = true;
    //try
    //{

    //    DataRow r = dtpresident.Rows[0];
    //    string sql = string.Join(Environment.NewLine, $"update president set",

    //        // $"PartyName='{r["PartyName"]}'",
    //        $"FirstName='{r["FirstName"]}'",
    //        $"LastName='{r["LastName"]}'",
    //         $"DateBorn='{r["DateBorn"]}'",
    //        $"TermStart='{r["TermStart"]}'",
    //        $"where Presidentid= {r["PresidentId"]}");


    //    Debug.Print("---------------------");

    //    SQLUtility.GetDataTable(sql);
    //    Application.UseWaitCursor = true;
    //    try
    //    {
    //        President.Save(dtpresident);
    //        bindsource.ResetBindings(false);

    //    }
    //    catch (Exception ex)
    //    {

    //        MessageBox.Show(ex.Message, "RecordKeeper");
    //    }
    //    finally
    //    {
    //        Application.UseWaitCursor = false;
    //    }

    private void Save()
    {
        Application.UseWaitCursor = true;
        try
        {
            President.Save(dtpresident);
            bindsource.ResetBindings(false);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "RecordKeeper");
        }
        finally
        {
            Application.UseWaitCursor = false;
        }
    }

    private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
 
