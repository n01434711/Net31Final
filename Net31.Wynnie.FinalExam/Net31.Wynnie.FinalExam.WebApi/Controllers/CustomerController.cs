using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic;
using Net31.Wynnie.FinalExam.EntityFrameworkDataAccess;
using Net31.Wynnie.FinalExam.Pocos;
using System;

namespace Net31.Wynnie.FinalExam.WebApi.Controllers
{
    [Route("api/simpleshop/v1/")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly CustomerLogic _logic;

        public CustomerController()
        {
            var repo = new GenericRepository<CustomerPoco>();
            _logic = new CustomerLogic(repo);
        }

        [HttpGet]
        [Route("customer/{customerId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetApplicantEducation(Guid customerId)
        {
            try
            {
                var poco = _logic.Get(customerId);
                return poco != null ? Ok(poco) : (ActionResult)NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("customers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetAllApplicantEducation()
        {
            try
            {
                var pocos = _logic.GetAll();
                return pocos.Count > 0 ? Ok(pocos) : (ActionResult)NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("customer/create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PostApplicantEducation([FromBody] CustomerPoco[] pocos)
        {
            try
            {
                _logic.Add(pocos);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("customer/update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PutApplicantEducation([FromBody] CustomerPoco[] pocos)
        {
            try
            {
                _logic.Update(pocos);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("customer/delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteApplicantEducation([FromBody] CustomerPoco[] pocos)
        {
            try
            {
                _logic.Delete(pocos);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
