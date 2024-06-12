using CRMApi.BLL;
using CRMApi.Entity.Models;
using CRMApi.Entity.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRelationShipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateCustomerController : ControllerBase
    {

        [HttpPost]
        public async Task<ApiResponse> UpdateCustomers(UpdateCustomer CustomerDetail)
        {

            dynamic response = await new CRMUpdateBll().updateCustomers(CustomerDetail);

            return response;

        }
    }
}
