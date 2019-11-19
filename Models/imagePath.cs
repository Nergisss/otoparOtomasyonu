using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace otopark.Models
{ 
    public class imagePath
    {
        public int Id{get;set;}
        public string resimyolu{get;set;}
        [NotMapped]
        public IFormFile ResimDosyasi{get;set;}

    }
}