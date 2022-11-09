using BookingService.InfrastructureLayer.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingService.InfrastructureLayer.Data
{
    public class Response
    {
        public Response()
        {

        }

        public Response(SystemCode code, string message, dynamic data)
        {
            this.Code = code;
            this.Message = message;
            this.Data = data;
        }
        public SystemCode Code { get; set; }
        public string? Message { get; set; }
        public dynamic? Data { get; set; }
    }
}
