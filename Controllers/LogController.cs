using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Log_Service.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Log_Service.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1")]
    public class LogController : Controller
    {
        [HttpPost]
        [Route("log")]
        public JsonResult logFunction([FromBody] LogModel Log)
        {
            string json = JsonConvert.SerializeObject(Log, Formatting.Indented);              // encode json and prettifying
            var Path = "Logs/log_" + DateTime.Now.ToString("yyyy_MM_dd-HH_mm_ss") + ".json";  // file name will be like this log_2020_05_1601-00_36_346.json
            System.IO.File.WriteAllText(Path, json);                                          // store in Log directory
            return Json(new { status = 200, message = "Log File Generated Successfully" }); 
        }
    }
}