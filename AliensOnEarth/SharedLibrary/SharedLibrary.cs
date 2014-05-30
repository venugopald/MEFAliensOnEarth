using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedLibrary
{

    public interface IPlugin
    {
        
        void AliensMainMethod();
    }



    public class Class1
    {
        public IPlugin AlienPlugin { get; set; }
    }
}
