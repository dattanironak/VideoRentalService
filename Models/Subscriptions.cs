using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VRSystem.Models
{
    public class Subscriptions
    {
        [Key]
        public int Id { get; set; }


        public int? Vid { get; set; }
        [ForeignKey("Vid")]
        public virtual Videos Video { get; set; }

        public string UserName { get; set; }
       
       
        

        

        [DataType(DataType.Date)]
        public DateTime ValidateTill { get; set; }

        public bool IsActive { get; set; }
    }
}
