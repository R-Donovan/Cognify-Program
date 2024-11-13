using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognify.Models
{
    public class Criminal
    {
        public string Name { get; set; }
        public string CrimeType { get; set; }
        public bool IsRehabilitated { get; set; }

        public Criminal(string name, string crimeType)
        {
            Name = name;
            CrimeType = crimeType;
            IsRehabilitated = false;
        }
    }

}
