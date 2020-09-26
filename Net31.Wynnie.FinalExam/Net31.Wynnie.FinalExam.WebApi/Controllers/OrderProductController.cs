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
    public class OrderProductController : ControllerBase
    {

        private readonly OrderProductLogic _logic;

        public OrderProductController()
        {
            var repo = new GenericRepository<OrderProductPoco>();
            _logic = new OrderProductLogic(repo);
        }

        [HttpGet]
        [Route("orderproduct/{orderProductId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetApplicantEducation(Guid orderProductId)
        {
            try
            {
                var poco = _logic.Get(orderProductId);
                return poco != null ? Ok(poco) : (ActionResult)NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("orderproducts")]
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
        [Route("orderproduct/create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PostApplicantEducation([FromBody] OrderProductPoco[] pocos)
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
        [Route("orderproduct/update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PutApplicantEducation([FromBody] OrderProductPoco[] pocos)
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
        [Route("orderproduct/delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteApplicantEducation([FromBody] OrderProductPoco[] pocos)
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
