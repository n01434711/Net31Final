using Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic;
using Net31.Wynnie.FinalExam.Pocos;
using System.Collections.Generic;

namespace Net31.Wynnie.FinalExam.BusinessLogic.Verify
{
    public interface IVerifyLogic<TPoco> where TPoco : class, IPoco
    {
        IEnumerable<ValidationException> VerifyPoco(TPoco poco);
    }
}
