using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frojack0809.MODEL
{
    class PTcu
    {
        string name;
        string age;
        string tel;
        string gender;
        string coid;

        public PTcu(string name, string age, string tel, string gender)
        {
            this.name = name;
            this.age = age;
            this.tel = tel;
            this.gender = gender;
        }

        public PTcu(string name, string age, string tel, string gender, string coid)
        {
            this.name = name;
            this.age = age;
            this.tel = tel;
            this.gender = gender;
            this.coid = coid;
        }

        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Coid { get => coid; set => coid = value; }
    }
}
