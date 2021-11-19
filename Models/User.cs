using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_RPG.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public byte[] PassworkHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public List<Character> Characters { get; set; }
    }
}