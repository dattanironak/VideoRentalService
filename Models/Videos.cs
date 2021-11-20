using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VRSystem.Models
{
    public class Videos
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public string Desc { get; set; }
        public int Time { get; set; }
        public bool Available { get; set; }

        public int Price { get; set; }

        public string ImagePath { get; set; }

        public string VideoPath { get; set; }


    }
}
