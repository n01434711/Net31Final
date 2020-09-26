using Net31.Wynnie.FinalExam.BusinessLogic.Verify;
using Net31.Wynnie.FinalExam.EntityFrameworkDataAccess;
using Net31.Wynnie.FinalExam.Pocos;

namespace Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic
{
    public class ProductLogic : BaseLogic<ProductPoco>
    {
        public ProductLogic(IDataRepository<ProductPoco> repository) : base(repository)
        {
            _verifyPoco = new ProductVerifyLogic();
        }
    }
}
