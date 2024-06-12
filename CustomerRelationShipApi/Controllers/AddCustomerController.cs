using CRMApi.BLL;
using CRMApi.Entity.Models;
using CRMApi.Entity.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRelationShipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        [HttpPost]
        public async Task<ApiResponse> NewCustomer(NewCustomer CustomerDetail)
        {

            dynamic response = await new CRMAddBll().AddCustomers(CustomerDetail);

            return response;

        }
    }
}
