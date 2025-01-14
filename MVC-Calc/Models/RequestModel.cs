using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Calc.Models
{
    public class RequestModel
    {
        [Required(ErrorMessage = "First number is required.")] //Make it nullable so it takes Required into consideration
        public double? Num1 { get; set; }
        [Required(ErrorMessage = "Second number is required.")]
        public double? Num2 { get; set; }

        [Required(ErrorMessage = "Operation tab is required.")]
        public Operations? Operation { get; set; }
    }

    public enum Operations
    {
        Add = 0, 
        Substract,
        Multiply,
        Divide
    }
}