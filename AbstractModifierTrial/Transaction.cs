using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractModifierTrial
{
    public class Transaction : BaseModel
    {
        public string Id { get; set; } = string.Empty;
        public string BusinessType { get; set; } = string.Empty;
    }
}
