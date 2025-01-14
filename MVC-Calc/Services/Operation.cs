using MVC_Calc.Services.Interfaces;
using MVC_Calc.Models;


namespace MVC_Calc.Services

{
    public class Operation : IOperation
    {
        public ResponseModel Calculate(RequestModel request)
        {
            var response = new ResponseModel();
            try
            {
                switch (request.Operation)
                {
                    case Operations.Add:
                        response.Result = request.Num1 + request.Num2;
                        break;
                    case Operations.Substract:
                        response.Result = request.Num1 - request.Num2;
                        break;
                    case Operations.Multiply:
                        response.Result = request.Num1 * request.Num2;
                        break;
                    case Operations.Divide:
                        if(request.Num2 == 0)
                        {
                            response.ErrorMessage = "Cannot divide by zero";
                        }
                        else
                        {
                            response.Result = request.Num1 / request.Num2;
                        }
                        break;
                    default:
                        response.ErrorMessage = "Invalid Operation";
                        break;
                }
            }
            catch (Exception ex) 
            {
                response.ErrorMessage = $"An error occured:  + {ex}"; 
            }
            return response;
        }
    }
}
