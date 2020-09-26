using Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic;
using Net31.Wynnie.FinalExam.Pocos;
using System.Collections.Generic;

namespace Net31.Wynnie.FinalExam.BusinessLogic.Verify
{
    public class CustomerVerifyLogic : IVerifyLogic<CustomerPoco>
    {
        public IEnumerable<ValidationException> VerifyPoco(CustomerPoco poco)
        {
            var exceptions = new List<ValidationException>();
            if (string.IsNullOrEmpty(poco?.Name) || poco?.Name?.Length < Constants.CUSTOMER_NAME_LENGTH_MIN)
            {
                exceptions.Add(new ValidationException(Constants.CUSTOMER_NAME_ERROR, $"{poco.GetType()} Name cannot be empty or less than {Constants.CUSTOMER_NAME_LENGTH_MIN} characters."));
            }
            if (poco?.Age < Constants.CUSTOMER_AGE_MIN || poco?.Age > Constants.CUSTOMER_AGE_MAX)
            {
                exceptions.Add(new ValidationException(Constants.CUSTOMER_AGE_ERROR, $"{poco.GetType()} Age must be between {Constants.CUSTOMER_AGE_MIN} and {Constants.CUSTOMER_AGE_MAX}"));
            }

            return exceptions;
        }
    }
}
