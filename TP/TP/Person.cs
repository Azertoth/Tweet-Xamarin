using System;
using System.Collections.Generic;
using System.Text;

namespace TP
{
    class Person
    {
        public string Identifiant { get; set; }
        public string Password { get; set; }

        public Person(string _ident, string _pass)
        {
            this.Identifiant = _ident;
            this.Password = _pass;
        }
    }
}
