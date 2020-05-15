using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Log_Service.Model
{
    public class LogModel
    {
        [Required]
        public int LogLevel { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Data { get; set; }
    }
}
