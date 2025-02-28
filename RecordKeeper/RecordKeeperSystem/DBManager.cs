using CPUFramework;

namespace RecordKeeperSystem
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionString)
        {   
            SQLUtility.ConnectionString = connectionString;
        }

        public static string SetConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}
