namespace ReturnHTML.Services
{
    public class WelcomeService
    {
        public static string WelcomeHTML(string name)
        {
            try
            {
                var html = System.IO.File.ReadAllText(@"./Html/HomePage.html");

                html = html.Replace("{{name}}", name);

                return html;
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = ex.Message;

                return response.Success + "\n " + response.Message;
            }
        }
    }
}
