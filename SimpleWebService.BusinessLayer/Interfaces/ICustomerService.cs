using SimpleWebService.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebService.BusinessLayer.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerModel> GetCustomerList();
        bool CreateNewCustomer(CustomerModel newCustomer);
        CustomerModel GetCustomerByEmail(string email);
    }
}
