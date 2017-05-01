using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipac
{
    /// <summary>
    /// Employee object, used primarily for serialization.
    /// Simplified version of User object.
    /// </summary>
    public class Employee
    {
        public string username { get; set; }    
        public string perm { get; set; }        // Permission: integer value representing a rank.
        public string name { get; set; }
    }
}
