﻿using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CRMApi.Entity.Models;
using System.Net;

namespace CRMApi.DAL
{
    public class DataFromDb
    {
        SqlConnection con = new SqlConnection("DATA SOURCE=192.168.147.100,14367;DATABASE=Demo_CRM;UID=Fourqtcrm;PWD=B614@#$Sector62");
       
        public async Task<dynamic>? GetAllCustomers()
        {
            DataSet ds = new DataSet();

            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("Practice_API_IUDS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action ", 'S');
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
               

                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds;

                }   

            }
            catch (Exception ex) { }

            return ds;
        }
    }
}
