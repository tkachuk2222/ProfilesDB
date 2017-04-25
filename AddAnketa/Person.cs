using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAnketa
{
    public class Person
    {
        public string FirstName      { set; get; }
        public string Lasname   { set; get; }
        public string Email     { set; get; }
        public string Number    { set; get; }

        public override string ToString()
        {
            return $"{FirstName}, {Lasname}, {Email}, {Number}";
        }
    }
}
