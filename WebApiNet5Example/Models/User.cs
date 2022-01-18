using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model = WebApiNet5Example.Models.Address;

namespace WebApiNet5Example.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Model.Address Address { get; set; }
    }
}
