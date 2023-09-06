using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOOPMVC.Sevice;

namespace TestOOPMVC.Model
{
    public abstract class Cat
    {
        public int ID { get; set; }
        public string TenMeo { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public Kieukeu Kieukeu { get; set; }

        public string Keu()
        {
            return Kieukeu.Keu();
        }
    }
}
