using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LineUtil.Defined
{
    public class LuCommandCollection : KeyedCollection<string, LuCommand>
    {
        public LuCommandCollection() {
            
        }

        protected override string GetKeyForItem(LuCommand item)
        {
            throw new NotImplementedException();
        }
    }
}
