using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipac
{
    ///<summary>
    /// Associates a permission value with a title, used primarily for
    /// serialization.
    ///</summary>
    public class Rank
    {
        public int rank { get; set; }           // Integer value of permission level.

        public string title { get; set; }       // Title of given rank.
    }
}
