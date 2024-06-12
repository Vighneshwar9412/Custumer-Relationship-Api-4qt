using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRMApi.Entity.Models;
using CRMApi.Entity.Responses;
using CRMApi.BLL;
using CRMApi.DAL;

namespace CustomerRelationShipApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AllCustomerController : ControllerBase
    {
        [Route("all")]
        [HttpGet]
        public async Task<dynamic> AllCustomers() {
                
            dynamic  response = await new CustomerBll().CustomersLogicBll();

            return new ApiResponse() { status = System.Net.HttpStatusCode.OK , IsSuccess = true,Message = { }, Body =   response  };

        }

        [Route("search")]
        [HttpPost]
        public async Task<dynamic> Search(DCustomer data)
        {

            dynamic response = await new SearchBll().CustomersLogicBll(data);

            return new ApiResponse() { status = System.Net.HttpStatusCode.OK, IsSuccess = true, Message = { }, Body = response };

        }

        [Route("delete")]
        [HttpDelete]
        public async Task<dynamic> DeleteCustomers(CustomerId Id)
        {

            dynamic response = await new CRMDeleteBll().DeleteCustomer(Id);

            return response;

        }

    }
}
