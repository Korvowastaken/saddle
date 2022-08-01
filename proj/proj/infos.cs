using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class infos
    {
        static private List<infos> list = new List<infos>();
        public int Number { get; set; }
        public string Date { get; set; }
        public int Inv_Num { get; set; }
        public string Obj_name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public Boolean isAvailable { get; set; }
        public void save()
        {
            list.Add(this);
        }
        static public List<infos> GetAllProducts()
        {
            return list;
        }
    }
}
