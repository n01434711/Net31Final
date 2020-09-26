using Net31.Wynnie.FinalExam.BusinessLogic.Verify;
using Net31.Wynnie.FinalExam.EntityFrameworkDataAccess;
using Net31.Wynnie.FinalExam.Pocos;

namespace Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic
{
    public class CustomerLogic : BaseLogic<CustomerPoco>
    {
        public CustomerLogic(IDataRepository<CustomerPoco> repository) : base(repository)
        {
            _verifyPoco = new CustomerVerifyLogic();
        }
    }
}
