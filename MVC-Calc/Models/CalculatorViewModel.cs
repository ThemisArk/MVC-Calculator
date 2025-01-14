using System.ComponentModel.DataAnnotations;

namespace MVC_Calc.Models
{
    public class CalculatorViewModel
    {
        
        public RequestModel RequestModel { get; set; }

        public ResponseModel? ResponseModel { get; set; }
    }
}
