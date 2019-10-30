using SimpleWebService.DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebService.DataAccessLayer
{
    public interface ICustomerDbService
    {
        CustomerModelDTO GetCustomerByEmail(string email);
        List<CustomerModelDTO> GetCustomerList();
        bool CreateNewCustomer(CustomerModelDTO newCustomer);

    }
}
