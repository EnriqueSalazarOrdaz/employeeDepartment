using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace eManager.Models
{
    public class CreateEmployeeViewModel
    {
        [HiddenInput(DisplayValue =false)]
        public int departmentId { get; set; }

        [Required]
        public string name { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}