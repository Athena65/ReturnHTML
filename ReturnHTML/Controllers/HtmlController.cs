using Microsoft.AspNetCore.Mvc;
using ReturnHTML.Services;

namespace ReturnHTML.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class HtmlController : ControllerBase
    {
        [HttpGet]
        public ContentResult Index()
        {
            try
            {
                var html = "<p>Html Code</p>";

                return base.Content(html, "text/html");
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = $"<p>{ex.Message} </p>";

                return base.Content(response.Message, "text/html");
            }

        }
        [HttpGet]
        public ContentResult Verify()
        {
            try
            {
                var html = "<div> Your acc has benn verified! </div>";

                return base.Content(html, "text/html");
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = $"<p>{ex.Message}</p>";

                return base.Content(response.Message, "text/html");
            }
        }

        [HttpGet]
        public ContentResult ConfirmVerify()
        {
            try
            {
                var html = System.IO.File.ReadAllText(@"./Html/verified.html");

                return base.Content(html, "text/html");

            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = $"<p>{ex.Message}</p>";

                return base.Content(response.Message, "text/html");
            }
        }


        [HttpGet]
        public ContentResult Welcome(string name)
        {
            try
            {
                var html = WelcomeService.WelcomeHTML(name);

                return base.Content(html, "text/html");
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = $"<p>{ex.Message}</p>";

                return base.Content(response.Message, "text/html");
            }
        }
    }
}
        
    

    


