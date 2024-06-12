using CRMApi.DAL;
using CRMApi.Entity.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMApi.Entity.Models;
using System.Net;
using System.Reflection;

namespace CRMApi.BLL
{
    public class CustomerBll
    {
        List<Customer> CustomersList = new List<Customer> ();

        public async Task<dynamic> CustomersLogicBll()
        {
            dynamic Response = await new DataFromDb().GetAllCustomers();

              
            DataSet ds = Response;
            if (ds != null) {
                DataTable Customers  = ds.Tables[0];

                foreach(DataRow row in Customers.Rows)
                {

                    CustomersList.Add(new Customer() {
                        Registration_Id = row["Registration_Id"].ToString(),
                        CustomerName = row["CustomerName"].ToString(),
                        RegistrationNo = row["RegistrationNo"].ToString(),
                        Gender = row["Gender"].ToString(),
                        DOB = row["DOB"].ToString(),
                        Address = row["Address"].ToString(),
                        MobileNo = row["MobileNo"].ToString(),
                        Active = row["Active"].ToString(),
                        CreatedBy = row["CreatedBy"].ToString(),
                        CreatedDate = row["CreatedDate"].ToString(),
                        ModifyBy = row["ModifyBy"].ToString(),
                        ModifyDate = row["ModifyDate"].ToString()
                    });
                }

            }
            return CustomersList;

        }
    }
}