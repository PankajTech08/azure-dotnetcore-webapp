using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace my_dotnetcore_webapp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IConfiguration _config;
        public HomeController(IConfiguration config)
        {
            _config = config;

        }

        public async Task<IActionResult> Index()
        {
            //ViewBag.Names = await GetNamesAsync();
            return View();
        }
        [HttpGet]
        [Route("employees")]
        public async Task<IActionResult> GetNames()
        {
           // var names = await GetNamesAsync();
            return Json("no name: azure subscription ended");
        }
        public async Task<List<string>> GetNamesAsync()
        {
            var result = new List<string>();
            string connStr = _config.GetConnectionString("AzureSqlConnection");

            using (var conn = new SqlConnection(connStr))
            {
                await conn.OpenAsync();
                var cmd = new SqlCommand("SELECT FirstName, LastName, Email FROM Employees", conn);
                var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var firstName = reader.GetString(0);
                    var lastName = reader.GetString(1);
                    var email = reader.GetString(2);
                    result.Add($"{firstName} {lastName} ({email})");
                }
            }
            return result;
        }
    }
}
