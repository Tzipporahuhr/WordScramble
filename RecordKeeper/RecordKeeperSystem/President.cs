using System.Diagnostics;

namespace RecordKeeperSystem
{
    public class President
    {
        public static DataTable SearchPresidents(string lastname)
        {
            DataTable dt = new();
           
            SqlCommand cmd =SQLUtility.GetSqlCommand("PresidentGet");
            
            
            cmd.Parameters["@LastName"].Value = lastname;
           dt=SQLUtility.GetDataTable(cmd);
             
            return dt;
        }


        public static DataTable Load(int presidentid)
        {
            DataTable dt = new();
            
            SqlCommand cmd =  SQLUtility.GetSqlCommand("PresidentGet");
           

           
           


            cmd.Parameters["@President"].Value = presidentid;

         
            dt=SQLUtility.GetDataTable(cmd);
             
           
            return dt;
        }


        [Obsolete]
        public static DataTable GetPartyList()
        {
            DataTable dt = new();
           
            SqlCommand cmd = SQLUtility.GetSqlCommand("PartyGet");

          

            cmd.Parameters["@All"].Value = 1;

           
         dt=SQLUtility.GetDataTable(cmd);

            return dt;

        }


        public static void Save(DataTable dtpresident)
        {
            //SQLUtility.DebugPrintDataTable(dtpresident);
            DataRow r = dtpresident.Rows[0];
            int id = (int)r["PresidentId"];
//added to to error
            if (r["TermEnd"] != DBNull.Value && r["TermStart"] != DBNull.Value)
            {
                int termStart = Convert.ToInt32(r["TermStart"]);
                int termEnd = Convert.ToInt32(r["TermEnd"]);

                if (termStart > termEnd)
                {
                    throw new Exception("TermEnd cannot be before TermStart");
                }
            }
            int newNum = Convert.ToInt32(r["Num"]);
            int existingId = SQLUtility.GetFirstColumnFirstRowValue($@"
        select isnull(max(PresidentId), 0)
        from president
        where Num = {newNum} and PresidentId <> {id}");

            if (existingId > 0)
            {
                throw new Exception("President number must be unique");
            }
            //until here
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update president set",

                    $"PartyId='{r["PartyId"]}',",
                    $"Num ='{r["Num"]}',",
                    $"FirstName='{r["FirstName"]}',",
                    $"LastName='{r["LastName"]}',",
                    $"DateBorn='{r["DateBorn"]}',",
                    $"TermStart='{r["TermStart"]}'",
                   $"where PresidentId={r["PresidentId"]}");
            }
            else



            {

                sql = "insert president(PartyId, Num, FirstName, LastName, DateBorn, TermStart) ";
                sql += $"select '{r["PartyId"]}', {r["Num"]}, '{r["FirstName"]}', '{r["LastName"]}', '{r["DateBorn"]}', {r["TermStart"]} ";
            }

            Debug.Print("-------------------");

            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtpresident)
        {
            int id = (int)dtpresident.Rows[0]["PresidentId"];
            SqlCommand cmd= SQLUtility.GetSqlCommand("PresidentDelete");
            cmd.Parameters["@PresidentId"].Value = id;


            SQLUtility.ExecuteSQL(cmd);
            
        }
    }
}
