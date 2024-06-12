using CRMApi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CRMApi.Entity.Responses
{
    public class ApiResponse
    {
        [DataMember]
        public HttpStatusCode status { set; get; }
        [DataMember]
        public Boolean IsSuccess { set; get; }
        [DataMember]
        public string Message { set; get; }
        [DataMember]
        public dynamic Body { set; get; }
        
    }
}
