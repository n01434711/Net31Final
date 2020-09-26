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
    public class ProductController : ControllerBase
    {

        private readonly ProductLogic _logic;

        public ProductController()
        {
            var repo = new GenericRepository<ProductPoco>();
            _logic = new ProductLogic(repo);
        }

        [HttpGet]
        [Route("product/{productId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetApplicantEducation(Guid productId)
        {
            try
            {
                var poco = _logic.Get(productId);
                return poco != null ? Ok(poco) : (ActionResult)NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("products")]
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
        [Route("product/create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PostApplicantEducation([FromBody] ProductPoco[] pocos)
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
        [Route("product/update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PutApplicantEducation([FromBody] ProductPoco[] pocos)
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
        [Route("product/delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteApplicantEducation([FromBody] ProductPoco[] pocos)
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
