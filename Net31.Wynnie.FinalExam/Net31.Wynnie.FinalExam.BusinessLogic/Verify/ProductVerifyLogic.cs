using Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic;
using Net31.Wynnie.FinalExam.Pocos;
using System.Collections.Generic;

namespace Net31.Wynnie.FinalExam.BusinessLogic.Verify
{
    public class ProductVerifyLogic : IVerifyLogic<ProductPoco>
    {
        public IEnumerable<ValidationException> VerifyPoco(ProductPoco poco)
        {
            var exceptions = new List<ValidationException>();
            if (string.IsNullOrEmpty(poco?.ProductName) || poco?.ProductName?.Length < Constants.PRODUCT_NAME_LENGTH_MIN)
            {
                exceptions.Add(new ValidationException(Constants.PRODUCT_NAME_ERROR, $"{poco.GetType()} Product Name cannot be empty or less than {Constants.PRODUCT_NAME_LENGTH_MIN} characters."));
            }
            return exceptions;
        }
    }
}
