using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleWebService.BusinessLayer.Interfaces;
using SimpleWebService.BusinessLayer.Models;


namespace SimpleWebService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customer
        [HttpGet]
        public List<CustomerModel> GetCustomersList()
        {
            return _customerService.GetCustomerList();
        }

        // GET: api/Customer/5
        [HttpGet("{email}")]
        public CustomerModel GetCustomerById(string email)
        {
            return _customerService.GetCustomerByEmail(email);
        }

        // POST: api/Customer
        [HttpPost]
        public ActionResult CreateNewCustomer([FromBody] CustomerModel customer)
        {
                if (customer == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    if (_customerService.CreateNewCustomer(customer))
                    {
                        return Ok();
                    }
                    else
                    {
                        return BadRequest();
                    }         
                }
            
        }
    }
}
