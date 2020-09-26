using Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic;
using Net31.Wynnie.FinalExam.Pocos;
using System.Collections.Generic;

namespace Net31.Wynnie.FinalExam.BusinessLogic.Verify
{
    public class OrderVerifyLogic : IVerifyLogic<OrderPoco>
    {
        public IEnumerable<ValidationException> VerifyPoco(OrderPoco poco)
        {
            var exceptions = new List<ValidationException>();
            if (poco?.OrderDate < Constants.ORDER_DATE_MIN || poco?.OrderDate > Constants.ORDER_DATE_MAX)
            {
                exceptions.Add(new ValidationException(Constants.ORDER_DATE_ERROR, $"{poco.GetType()} Order Date must be between {Constants.ORDER_DATE_MIN:yyyy-mm-dd} and {Constants.ORDER_DATE_MAX:yyyy-mm-dd}"));
            }
            return exceptions;
        }
    }
}
