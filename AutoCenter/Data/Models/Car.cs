using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCenter.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CarModel { get; set; }
        public string Desc { get; set; }
        public int Price { get; set; }
        public string Img { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
