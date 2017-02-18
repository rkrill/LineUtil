using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineUtil.Defined
{
    public enum ArgumentTypes {
        Object = 0,
        String =1,
        Int = 2,
        Bool = 3, 
        Enum =4
    }

    public class LuArgument
    {
        public LuArgument() { }
        public string Name { get; set; }
        public int Position { get; set; }
        public ArgumentTypes Type { get; set; }
        public bool IsOptional { get; set; }
        public string DefaultValue { get; set; }
        public Func<string>[] Contraints { get; }

    }
}
 