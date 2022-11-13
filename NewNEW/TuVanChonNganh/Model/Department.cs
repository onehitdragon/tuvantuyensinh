using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuVanChonNganh.Model
{
    public class Department
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Department(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}