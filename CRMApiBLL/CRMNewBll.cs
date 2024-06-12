using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace CRMApi.BLL
{
    public class CRMNewBll
    {

        public void method() {

            string sp = "Practice_API_IUDS";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter() { ParameterName = "@Action", Value = "S" });




        }

        public static async Task<DataSet> GetDatasetAsyncNew(String Key, CommandType cmdType, string cmdText, List<SqlParameter> cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection conn = new SqlConnection(GetClientConnectionString(Key)))
                {
                    PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);

                    IDataReader reader = await cmd.ExecuteReaderAsync();
                    while (!reader.IsClosed)
                    {
                        ds.Tables.Add().Load(reader);
                    }
                }
            }
            catch
            {
                throw;
            }
            return ds;
        }

    }
}
*/
