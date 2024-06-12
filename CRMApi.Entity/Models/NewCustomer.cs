

using System.Runtime.Serialization;

namespace CRMApi.Entity.Models
{
    public class NewCustomer
    {


        public int Login_Id { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }
        public string Mobile { get; set; }

        public DateTime DOB { get; set; }

        


    }
}
