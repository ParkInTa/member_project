using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frojack0809
{
    class Customer
    {
        
        string name;
        string age;
        string tel;
        string addr;
        string wnals;
        string gender;
        string cid;

        public Customer(string name, string age, string tel, string addr, string wnals, string gender)
        {
            this.name = name;
            this.age = age;
            this.tel = tel;
            this.addr = addr;
            this.wnals = wnals;
            this.gender = gender;
        }

        public Customer(string name, string age, string tel, string addr, string wnals, string gender, string cid)
        {
            this.name = name;
            this.age = age;
            this.tel = tel;
            this.addr = addr;
            this.wnals = wnals;
            this.gender = gender;
            this.cid = cid;
        }


        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Wnals { get => wnals; set => wnals = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Cid { get => cid; set => cid = value; }
    }
}
