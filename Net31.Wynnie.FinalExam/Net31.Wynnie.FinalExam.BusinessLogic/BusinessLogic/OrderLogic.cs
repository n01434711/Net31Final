using Net31.Wynnie.FinalExam.BusinessLogic.Verify;
using Net31.Wynnie.FinalExam.EntityFrameworkDataAccess;
using Net31.Wynnie.FinalExam.Pocos;

namespace Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic
{
    public class OrderLogic : BaseLogic<OrderPoco>
    {
        public OrderLogic(IDataRepository<OrderPoco> repository) : base(repository)
        {
            _verifyPoco = new OrderVerifyLogic();
        }
    }
}
