using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingService.InfrastructureLayer.Data.RequestModels
{
    public class UserAuthen
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string? Password { get; set; }
    }
}
