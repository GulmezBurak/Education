using Dapper;
using Microsoft.AspNetCore.Mvc;
using PersonelProje.Data;
using System.Data.SqlClient;

namespace PersonelProje.Controllers
{
    public class BaseController : Controller
    {

        IConfiguration _config; // newleme işlemi

        public BaseController(IConfiguration config)
        {
            _config = config;
        }
        public SqlConnection Connect()
        {
            return new SqlConnection(_config.GetConnectionString("Baglanti"));
        }

    }
}
