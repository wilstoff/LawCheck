using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawCheck
{
    public class Person : IEntity
    {
        public Dictionary<string, string> Rights { get; set; }
    }
}
