using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectVIII.Models.InputValidations;

namespace ProjectVIII.Models
{
    public class AdminRegister
    {
        //Property structures
        [DisplayName("Name")]
        [Required(ErrorMessage ="Name required!")]
        public string firstName { get; set; }

        [DisplayName("Surname")]
        [Required(ErrorMessage = "Surname required!")]
        public string lastName { get; set; }

        [Display(Name ="Student Number")]
        [Range(10000000,99999999,ErrorMessage ="Invalid student number")]
        [Required(ErrorMessage = "Student number required!")]
        public int studentNumber { get; set; }

        [DisplayName("ID number")]
        [Required(ErrorMessage = "ID number required!")]
        [IdNumber(ErrorMessage ="Invalid inputs")]
        public string idNumber { get; set; }

        [DisplayName("Email address")]
        [Required(ErrorMessage ="Email address required!")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Invalid email address!")]
        public string emailAddress { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage ="Password required!")]
        [StringLength(100,MinimumLength = 6,ErrorMessage ="Enter a strong password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [DisplayName("Confirm password")]
        [Compare("password",ErrorMessage ="Password does'nt match")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

        [DisplayName("Date of birth")]
        public string DOB { get; set; }

        [DisplayName("Age")]
        public int age { get; set; }

        [DisplayName("Gender")]
        public string gender { get; set; }

        //Methods
        public DateTime getDOB()//Extracting date of birth from an ID number
        {
            int Y, M, D;
            if (int.Parse(idNumber.Substring(0, 2)) > 99 ||
                int.Parse(idNumber.Substring(0, 2)) <= DateTime.Now.Year - 2000)
                Y = int.Parse(idNumber.Substring(0, 2)) + 2000;
            else
                Y = int.Parse(idNumber.Substring(0, 2)) + 1900;
            M = int.Parse(idNumber.Substring(2, 2));
            D = int.Parse(idNumber.Substring(4, 2));
            return (DateTime.Parse($"{Y}/{M}/{D}"));
        }
        public int calcAge()//Calculating Age
        {
            return DateTime.Now.Year - getDOB().Year;
        }
        public string getGender()//Determining the gender
        {
            if (int.Parse(idNumber.Substring(6, 4)) > 4999)
                return "Male";
            else
                return "Female";
        }
    }
}