using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using SharedLibrary; 

namespace MEFAliensPlugin
{


    class MEFAliensPlugin
    {
        static void Main(string[] args)
        {

            var pm = new PluginManager();
            pm.ExecutePlugin();
            Console.ReadLine();

        }
    }


    



}
