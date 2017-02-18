using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineUtil.Defined
{

    public enum DefinedFunctions
    {

        NONE = 0,
        TF_Trim =1,
        TF_Replace = 2
    }

    public enum CommandTypes {
        NONE = 0,
        LineCollectionMod,
        LineMod,
        LineAndCollectionMod
      

    }
    public enum ModificationTypes
    {
        None = 0,
        Line =1,
        LineCollection =2,
        LineAndLineCollection =3
    }

    public class LuCommand
    {

        /* Name,
        Arguments
        FunctionName,
           MinArgs,
           MaxArgs,
           ShortHelpText,
           SyntaxText,
           ExampleText,
           HelpText,
           CommandType*/ 

        public LuCommand() { }
        public string Name { get; private set; }
        public string LName { get; }
        public ModificationTypes ModificationType { get; private set; }
        public DefinedFunctions FunctionName { get; private set; }
        public int MinArgs { get; private set; }
        public int MaxArgs { get; private set; }

        internal class Help {
            public string ShortHelpText { get; set; }
            public string SyntaxText { get; private set; }
            public string ExampleText { get; private set; }
            public string HelpText { get; private set; }
        }

        
    }
}
