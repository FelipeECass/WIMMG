
using System.Data.Odbc;

namespace Parser.Utils
{
    public class DatabaseOperations(string p_ip, string p_user, string p_password, string p_database)
    {
        string m_stringConnection = "DRIVER={MySQL ODBC 8.0 Driver};" +
           $"SERVER={p_ip};" +
           $"DATABASE={p_database};" +
           $"UID={p_user};" +
           $"PASSWORD={p_password};";
        public bool PerformQuery(string p_query)
        {
            using (OdbcConnection v_connection = new OdbcConnection(m_stringConnection))
            {

                using (OdbcCommand v_command = new OdbcCommand(p_query, v_connection))
                {
                    try
                    {
                        v_command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
