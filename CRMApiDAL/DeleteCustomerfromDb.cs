using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMApi.Entity.Models;

namespace CRMApi.DAL
{
    public class DeleteCustomerfromDb
    {
        SqlConnection con = new SqlConnection("DATA SOURCE=192.168.147.100,14367;DATABASE=Demo_CRM;UID=Fourqtcrm;PWD=B614@#$Sector62");
        private CustomerId _data;

        public DeleteCustomerfromDb(CustomerId data) { 
        
            _data = data;
        }


        public async Task<dynamic>? DeleteCustomers()
        {

            List<dynamic> ResponseList = new List<dynamic>();
            int outputValue = 0;
            string outputMessageValue = "";
            try
            {
                

                con.Open();
                SqlCommand cmd = new SqlCommand("Practice_API_IUDS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action ", 'D');
                cmd.Parameters.AddWithValue("@Registration_Id", _data.Registration_Id);
               
                SqlParameter outputParam = new SqlParameter("@Status", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(outputParam);
                SqlParameter outputMessage = new SqlParameter("@OutMsg", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(outputMessage);

                await cmd.ExecuteNonQueryAsync();
                con.Close();
                // Access the output parameter value

                 outputValue = (int)outputParam.Value;
                 outputMessageValue = outputMessage.Value.ToString();

                
            }
            catch (Exception ex) { }

            ResponseList.Add(outputValue);
            ResponseList.Add(outputMessageValue);

            return ResponseList;
        }
    }
}
