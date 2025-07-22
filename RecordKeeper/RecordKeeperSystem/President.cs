using System.Diagnostics;

namespace RecordKeeperSystem
{
    public class President
    {
        [Obsolete]
        public static DataTable SearchPresidents(string lastname)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("PresidentGet");
            bool searchAll = string.IsNullOrWhiteSpace(lastname);
            SQLUtility.SetParamValue(cmd, "@LastName", lastname ?? "");
            SQLUtility.SetParamValue(cmd, "@All", searchAll ? 1 : 0);
           
            dt=SQLUtility.GetDataTable(cmd);
            return dt;
        }

         public static DataTable Load(int presidentid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("PresidentGet");
            SQLUtility.SetParamValue(cmd, "@President", presidentid);
            dt=SQLUtility.GetDataTable(cmd);
            return dt;
        }

        [Obsolete]
        public static DataTable GetPartyList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("PartyGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt=SQLUtility.GetDataTable(cmd);
            return dt;

        }
        //         public static void Save(DataTable dtpresident)
        //        {
        //            //SQLUtility.DebugPrintDataTable(dtpresident);
        //            DataRow r = dtpresident.Rows[0];
        //            SQLUtility.SaveDataRow(r, "PresidentUpdate");
        //////added to to error
        ////            if (r["TermEnd"] != DBNull.Value && r["TermStart"] != DBNull.Value)
        ////            {
        ////                int termStart = Convert.ToInt32(r["TermStart"]);
        ////                int termEnd = Convert.ToInt32(r["TermEnd"]);

        ////                if (termStart > termEnd)
        ////                {
        ////                    throw new Exception("TermEnd cannot be before TermStart");
        ////                }
        ////            }
        ////            int newNum = Convert.ToInt32(r["Num"]);
        ////            int existingId = SQLUtility.GetFirstColumnFirstRowValue($@"
        ////       // select isnull(max(PresidentId), 0)
        ////        //from president
        ////        //where Num = {newNum} and PresidentId <> {id}");

        ////            if (existingId > 0)
        ////            {
        ////                throw new Exception("President number must be unique");
        ////            }
        ////            //until here
        ////           // string sql = "";


        //            //SQLUtility.ExecuteSQL(sql);
        //        }

        public static void Save(DataTable dtpresident)
        {
            if (dtpresident.Rows.Count == 0)
            {
                throw new Exception("cannot call President Save method because there are no rows in the table");
            }
            DataRow r = dtpresident.Rows[0];

            if (r.RowState != DataRowState.Deleted)
            {

                if (r["TermEnd"] != DBNull.Value && r["TermStart"] != DBNull.Value)
                {
                    int termStart = Convert.ToInt32(r["TermStart"]);
                    int termEnd = Convert.ToInt32(r["TermEnd"]);

                    if (termStart > termEnd)
                    {
                        throw new Exception("TermEnd cannot be before TermStart");
                    }
                }
                SQLUtility.SaveDataRow(r, "PresidentUpdate");


                int newNum = Convert.ToInt32(r["Num"]);
                int currentId = r["PresidentId"] == DBNull.Value ? 0 : Convert.ToInt32(r["PresidentId"]);

                //    int existingId = SQLUtility.GetFirstColumnFirstRowValue($@"
                //select  isnull (max(PresidentId), 0)
                //from President
                //where Num = {newNum} AND PresidentId <> {currentId}");

                //    if (existingId > 0)
                //    {
                //        throw new Exception("President number must be unique");
                //    }
                //}
            }

            SQLUtility.SaveDataRow(r, "PresidentUpdate");
        }

        public static void Delete(DataTable dtpresident)
        {
            int id = (int)dtpresident.Rows[0]["PresidentId"];
            SqlCommand cmd= SQLUtility.GetSqlCommand("PresidentDelete");
            
            SQLUtility.SetParamValue(cmd, "@PresidentId", id);

            SQLUtility.ExecuteSQL(cmd);
            
        }
    }
}
