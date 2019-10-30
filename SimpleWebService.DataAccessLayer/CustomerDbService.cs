using SimpleWebService.DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SimpleWebService.DataAccessLayer
{
    public class CustomerDbService : ICustomerDbService
    {
        private static List<CustomerModelDTO> customersList =
            new List<CustomerModelDTO> {
                            new CustomerModelDTO{ Id=1,Age=21,Email="john@gmail.com",FirstName="John",LastName="Doe",Company="ABC"},
                            new CustomerModelDTO{ Id=2,Age=34,Email="mike@gmail.com",FirstName="Mike",LastName="Larrs",Company="ABC"},
                            new CustomerModelDTO{ Id=3,Age=50,Email="nemo@gmail.com",FirstName="Nemo",LastName="Phillis",Company="ABC"},
                            new CustomerModelDTO{ Id=5,Age=27,Email="jonny@gmail.com",FirstName="Jonny",LastName="Mattsson",Company="ABC"},
            };

        public bool CreateNewCustomer(CustomerModelDTO newCustomer)
        {
            customersList.Add(newCustomer);
            return true;
        }

        public CustomerModelDTO GetCustomerByEmail(string email)
        {
            var selectedCus = customersList.Where(a => a.Email == email).Select(x => x).FirstOrDefault();
            return selectedCus;
        }

        public List<CustomerModelDTO> GetCustomerList()
        {
            return customersList;
        }
    }
}
