using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApi.Entity.Models
{
    public class DCustomer
    {
        public int? Registration_Id { get; set; }
        public string? Name { get; set; }

        public string? RegistrationNo { get; set; }

        public string? Mobile { get; set; }
    }
}
