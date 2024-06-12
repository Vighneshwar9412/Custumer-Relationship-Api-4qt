﻿using CRMApi.DAL;
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
    public class CRMUpdateBll
    {
        List<dynamic> CustomersList = new List<dynamic>();

        public CRMUpdateBll()
        {

        }
        public async Task<ApiResponse> updateCustomers(UpdateCustomer Customer)
        {

            dynamic Response = await new UpdateCustomerToDb(Customer).UpdateCustomers();

            if (Response[0] > 0)
            {
                return new ApiResponse() { status = System.Net.HttpStatusCode.OK, IsSuccess = true, Message = Response[1], Body = { } };
            }

            return new ApiResponse() { status = System.Net.HttpStatusCode.BadRequest, IsSuccess = false, Message = "Opps! Looks like Something Went Wrong During Insertion ", Body = { } };

        }
    }
}