using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class UserInfo
    {

        // properties
        // [Required]// 
        //[RegularExpression("^[a-zA-Z]{2,30}$")]
        public string FirstName { set; get; }

        //[Required] // this field needs value
        // [RegularExpression("^[a-zA-Z]{2,30}$")]
        public string LastName { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Password { set; get; }

        // default constructor
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            Password = "";


        }
        //constructors with parameters
        public UserInfo(String fn, string ln, string em, string ph, string pass)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            PhoneNumber = ph;
            Password = pass;
        }
    }
}