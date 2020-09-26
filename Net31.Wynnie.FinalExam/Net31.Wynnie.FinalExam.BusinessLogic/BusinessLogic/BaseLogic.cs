using Net31.Wynnie.FinalExam.BusinessLogic.Verify;
using Net31.Wynnie.FinalExam.EntityFrameworkDataAccess;
using Net31.Wynnie.FinalExam.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic
{
    public abstract class BaseLogic<TPoco> where TPoco : class, IPoco
    {
        protected IDataRepository<TPoco> _repository;
        protected IVerifyLogic<TPoco> _verifyPoco;

        public BaseLogic(IDataRepository<TPoco> repository)
        {
            _repository = repository;
        }

        protected void Verify(TPoco[] pocos)
        {
            var exceptions = new List<ValidationException>();
            pocos.ToList().ForEach(poco => exceptions.AddRange(_verifyPoco.VerifyPoco(poco)));
            if (exceptions.Any()) throw new AggregateException(exceptions);
        }

        public virtual TPoco Get(Guid id)
        {
            return _repository.GetSingle(c => c.Id == id);
        }

        public virtual List<TPoco> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public virtual void Add(TPoco[] pocos)
        {
            Verify(pocos);
        }

        public virtual void Update(TPoco[] pocos)
        {
            Verify(pocos);
            _repository.Update(pocos);
        }

        public void Delete(TPoco[] pocos)
        {
            _repository.Remove(pocos);
        }
    }
}
