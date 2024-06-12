using CRMApi.DAL;
using CRMApi.Entity.Models;
using CRMApi.Entity.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApi.BLL
{
    public class CRMDeleteBll
    {
        
        public async Task<dynamic> DeleteCustomer(CustomerId data ) {

            dynamic response = await new DeleteCustomerfromDb(data).DeleteCustomers();

            if (response[0]>0) {

                return new ApiResponse() { status = System.Net.HttpStatusCode.OK, IsSuccess = true, Message = response[1], Body = { } };

            }

            return new ApiResponse() { status = System.Net.HttpStatusCode.BadRequest, IsSuccess = false, Message = "Oops! looks like something went wrong during delete " , Body = { } } ;  
        }
         
    }
}
