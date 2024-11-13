using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognify.Models
{
    public class Memory
    {
        public string Description { get; set; }
        public string EmotionalImpact { get; set; }

        public Memory(string description, string emotionalImpact)
        {
            Description = description;
            EmotionalImpact = emotionalImpact;
        }
    }

}
