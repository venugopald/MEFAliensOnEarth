using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using SharedLibrary;
using System.Reflection;
using System.ComponentModel.Composition.Hosting;

namespace MEFAliensPlugin
{
    public class PluginManager
    {
        [Import(typeof(IPlugin))]
        //public List<IPlugin> AlienPlugin { get; set; }
        public IPlugin AlienPlugin { get; set; }
        public void ExecutePlugin()
        {
            try
            {
                var catalog = new AggregateCatalog();
                catalog.Catalogs.Add(new DirectoryCatalog(@"C:\MEFAliensLibrary"));
                catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
                var container = new CompositionContainer(catalog);
                CompositionBatch batch = new CompositionBatch();

                batch.AddPart(this);
                container.Compose(batch);
                //container.ComposeParts(this);
                //AlienPlugin.AliensMainMethod();
                AlienPlugin.AliensMainMethod();
                //foreach (var IPlugin in AlienPlugin)
                //{
                    //IPlugin.AliensMainMethod();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            Console.ReadLine();
        }
    } 
}
