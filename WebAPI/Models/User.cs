using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebAPI.Models
{

    public enum UserType
    {
        artist,
        employee,
        customer
    }
    public class User
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public UserType UserType { get; set; }

        public bool IsActive { get; set; }
    }
}
