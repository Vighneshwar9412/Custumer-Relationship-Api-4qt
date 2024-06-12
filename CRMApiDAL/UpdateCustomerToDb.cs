using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CRMApi.Entity.Models;
using System.Net;

namespace CRMApi.DAL
{
    public class UpdateCustomerToDb
    {
        SqlConnection con = new SqlConnection("DATA SOURCE=192.168.147.100,14367;DATABASE=Demo_CRM;UID=Fourqtcrm;PWD=B614@#$Sector62");
        private UpdateCustomer _data;

        public UpdateCustomerToDb(UpdateCustomer data)
        {
            _data = data;

        }
        public async Task<dynamic>? UpdateCustomers()
        {

            List<dynamic> ResponseList = new List<dynamic>();
            int outputValue = 0;
            string outputMessageValue = "";
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("Practice_API_IUDS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action ", 'U');
                cmd.Parameters.AddWithValue("@Registration_Id ", _data.Registrstion_id);
                cmd.Parameters.AddWithValue("@Login_Id  ", _data.Login_Id);
                cmd.Parameters.AddWithValue("@Mobile  ", _data.Mobile);
                cmd.Parameters.AddWithValue("@FirstName  ", _data.FirstName);
                cmd.Parameters.AddWithValue("@LastName  ", _data.LastName);
                cmd.Parameters.AddWithValue("@Gender  ", _data.Gender);
                cmd.Parameters.AddWithValue("@Address  ", _data.Address);
                cmd.Parameters.AddWithValue("@DOB", _data.DOB);

                SqlParameter outputParam = new SqlParameter("@Status", _data.Status) { Direction = ParameterDirection.Output };
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
