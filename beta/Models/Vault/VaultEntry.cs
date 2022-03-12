using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta.Models.Vault
{
    class VaultEntry
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }


    class MapEntry : VaultEntry
    {
    }

    class ModEntry : VaultEntry
    {
    }
}
