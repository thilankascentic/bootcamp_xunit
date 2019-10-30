using SimpleWebService.BusinessLayer.Interfaces;
using SimpleWebService.BusinessLayer.Models;
using SimpleWebService.DataAccessLayer;
using SimpleWebService.DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWebService.BusinessLayer
{
    public class CustomerService : ICustomerService
    {
        public readonly ICustomerDbService _customerDbService;
        public CustomerService(ICustomerDbService customerDbService)
        {
            _customerDbService = customerDbService;
        }

        public bool CreateNewCustomer(CustomerModel newCustomer)
        {
            try
            {
                var saveObj = new CustomerModelDTO
                {
                    Id = newCustomer.Id,
                    Age = newCustomer.Age,
                    Company = newCustomer.Company,
                    Email = newCustomer.Email,
                    FirstName = newCustomer.FirstName,
                    LastName = newCustomer.LastName
                };
                var result = _customerDbService.CreateNewCustomer(saveObj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public CustomerModel GetCustomerByEmail(string email)
        {
            var customer = _customerDbService.GetCustomerByEmail(email);
            return new CustomerModel {
                Id=customer.Id,
                Age=customer.Age,
                Company=customer.Company,
                Email=customer.Email,
                FirstName=customer.FirstName,
                LastName=customer.LastName
            };
        }

        public List<CustomerModel> GetCustomerList()
        {
            List<CustomerModel> returnResult = new List<CustomerModel>();
            var cusList = _customerDbService.GetCustomerList();
            foreach (var item in cusList)
            {
                returnResult.Add(new CustomerModel {
                    Id= item.Id,
                    Age= item.Age,
                    Company=item.Company,
                    FirstName=item.FirstName,
                    LastName=item.LastName,
                    Email=item.Email
                });
            }
            return returnResult;
        }

    }
}
