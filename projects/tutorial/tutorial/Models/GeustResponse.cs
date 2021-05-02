using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tutorial.Models
{
    public class GeustResponse
    {
        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please select an option")]
        public bool? WillAttend { get; set; }
    }
}
