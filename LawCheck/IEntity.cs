using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawCheck
{
    /// <summary>
    /// Encapsulates functionality of a person/government/corporation
    /// </summary>
    public interface IEntity
    {
        Dictionary<string, string> Rights { get; set; }
    }
}
