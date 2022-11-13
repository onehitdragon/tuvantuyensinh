using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuVanChonNganh.Model
{
    public class PropertyHobby
    {
        private string id;
        private string groupHobbyId;
        private string property;

        public string Id { get => id; set => id = value; }
        public string GroupHobbyId { get => groupHobbyId; set => groupHobbyId = value; }
        public string Property { get => property; set => property = value; }

        public PropertyHobby(string id, string groupHobbyId, string property) 
        {
            this.id = id;
            this.groupHobbyId = groupHobbyId;
            this.property = property;
        }
    }
}