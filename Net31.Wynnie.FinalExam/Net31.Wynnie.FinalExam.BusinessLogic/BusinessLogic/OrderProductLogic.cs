using Net31.Wynnie.FinalExam.BusinessLogic.Verify;
using Net31.Wynnie.FinalExam.EntityFrameworkDataAccess;
using Net31.Wynnie.FinalExam.Pocos;

namespace Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic
{
    public class OrderProductLogic : BaseLogic<OrderProductPoco>
    {
        public OrderProductLogic(IDataRepository<OrderProductPoco> repository) : base(repository)
        {
            _verifyPoco = new OrderProductVerifyLogic();
        }
    }
}
