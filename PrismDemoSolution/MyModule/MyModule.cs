using System;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace MyModule
{
    public class MyModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        public MyModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("MyRegion", typeof(Views.MyModule));
        }
    }
}
