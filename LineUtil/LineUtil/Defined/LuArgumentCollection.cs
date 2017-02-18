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
    public class LuArgumentCollection : KeyedCollection<string, LuArgument>
    {
        public LuArgumentCollection() {
            
        }

        protected LuArgumentCollection(IEqualityComparer<string> comparer, int dictionaryCreationThreshold) : base(comparer, dictionaryCreationThreshold)
        {
        }

        protected override string GetKeyForItem(LuArgument item)
        {
            throw new NotImplementedException();
        }
    }
}
