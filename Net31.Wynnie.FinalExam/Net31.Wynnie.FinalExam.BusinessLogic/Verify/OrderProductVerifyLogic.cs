using Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic;
using Net31.Wynnie.FinalExam.Pocos;
using System.Collections.Generic;

namespace Net31.Wynnie.FinalExam.BusinessLogic.Verify
{
    public class OrderProductVerifyLogic : IVerifyLogic<OrderProductPoco>
    {
        public IEnumerable<ValidationException> VerifyPoco(OrderProductPoco poco)
        {
            return new List<ValidationException>();
        }
    }
}
