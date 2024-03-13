using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziStore.Models.DTOs
{
    public class Categoria
    {
        public int id { get; set; }
        public string name { get; set; } 
        public string image { get; set; } 
    } 

    public class Producto
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public Categoria category { get; set; }
        public List<string> images { get; set; }
    }
}
