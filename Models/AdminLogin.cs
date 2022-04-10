using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectVIII.Models
{
    public class AdminLogin
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email address required!")]
        public string emailAddress { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password required!")]
        public string password { get; set; }
    }
}