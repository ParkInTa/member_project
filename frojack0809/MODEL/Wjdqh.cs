using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frojack0809.MODEL
{
    class Wjdqh
    {
        string data;
        string rodnjf;
        string whdahr;
        string wjd;

        public Wjdqh(string data, string rodnjf, string whdahr)
        {
            this.data = data;
            this.rodnjf = rodnjf;
            this.whdahr = whdahr;
        }

        public Wjdqh(string data, string rodnjf, string whdahr, string wjd)
        {
            this.data = data;
            this.rodnjf = rodnjf;
            this.whdahr = whdahr;
            this.wjd = wjd;
        }

        public string Data { get => data; set => data = value; }
        public string Rodnjf { get => rodnjf; set => rodnjf = value; }
        public string Whdahr { get => whdahr; set => whdahr = value; }
        public string Wjd { get => wjd; set => wjd = value; }
    }
}
