using MVC_Calc.Models;

namespace MVC_Calc.Services.Interfaces
{
    public interface IOperation
    {
        public ResponseModel Calculate(RequestModel request);
    }
}
