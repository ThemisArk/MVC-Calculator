using Microsoft.AspNetCore.Mvc;
using MVC_Calc.Models;
using MVC_Calc.Services.Interfaces;

namespace MVC_Calc.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly IOperation _ioperation;

        //Constructor 
        public CalculatorController(IOperation ioperation)
        {
            _ioperation = ioperation;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var viewModel = new CalculatorViewModel()
            {
                RequestModel = new RequestModel(),
                ResponseModel = new ResponseModel()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Calculate(CalculatorViewModel viewModel)
        {
            var response = new ResponseModel();

            if(ModelState.IsValid)
            {
                response = _ioperation.Calculate(viewModel.RequestModel);
                viewModel.ResponseModel = response;
            }
            return View("Index", viewModel);
        }
    }
}