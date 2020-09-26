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
    public class OrderController : ControllerBase
    {

        private readonly OrderLogic _logic;

        public OrderController()
        {
            var repo = new GenericRepository<OrderPoco>();
            _logic = new OrderLogic(repo);
        }

        [HttpGet]
        [Route("order/{orderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetApplicantEducation(Guid orderId)
        {
            try
            {
                var poco = _logic.Get(orderId);
                return poco != null ? Ok(poco) : (ActionResult)NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("orders")]
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
        [Route("order/create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PostApplicantEducation([FromBody] OrderPoco[] pocos)
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
        [Route("order/update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PutApplicantEducation([FromBody] OrderPoco[] pocos)
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
        [Route("order/delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteApplicantEducation([FromBody] OrderPoco[] pocos)
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
