using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBackend.models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }

        // To create initial relationship link
        public Character Character { get; set; }
        

        // To set weapon as the dependent side of the relationship
        public int CharacterId { get; set; }
    }
}