using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractModifierTrial
{
    /*
     * The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. 
     * The abstract modifier can be used with classes, methods, properties, indexers, and events. 
     * Use the abstract modifier in a class declaration to indicate that a class is intended 
     * only to be a base class of other classes, not instantiated on its own. 
     * Members marked as abstract must be implemented by non-abstract classes that 
     * derive from the abstract class.
     */

    public abstract class BaseModel
    {
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
