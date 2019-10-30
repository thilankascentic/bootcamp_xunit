using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebService.BusinessLayer.Models
{
      public class CustomerModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }

    }
}
