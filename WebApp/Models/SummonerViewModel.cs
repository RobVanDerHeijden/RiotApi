using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SummonerViewModel
    {
        [Required(ErrorMessage = "Fill in SummonerName!")]
        public string SummonerName { get; set; }

        [Required(ErrorMessage = "Fill in Region!")]
        public string Region { get; set; }
    }
}
