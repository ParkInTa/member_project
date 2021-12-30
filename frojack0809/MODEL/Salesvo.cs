using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frojack0809.MODEL
{
    class Salesvo
    {
        string custname;
        string custage;
        string custgender;
        string wjdwhd;
        string manager;

        public Salesvo(string custname, string custage, string custgender, string wjdwhd, string manager)
        {
            this.custname = custname;
            this.custage = custage;
            this.custgender = custgender;
            this.wjdwhd = wjdwhd;
            this.manager = manager;
        }

        public string Custname { get => custname; set => custname = value; }
        public string Custage { get => custage; set => custage = value; }
        public string Custgender { get => custgender; set => custgender = value; }
        public string Wjdwhd { get => wjdwhd; set => wjdwhd = value; }
        public string Manager { get => manager; set => manager = value; }
    }
}
