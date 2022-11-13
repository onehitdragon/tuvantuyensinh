using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuVanChonNganh.Model
{
    public class GroupHobby
    {
        private string id;
        private string content;

        public string Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }

        public GroupHobby() { }
        public GroupHobby(string id, string content)
        { 
            this.id = id;
            this.content = content;
        }
    }
}