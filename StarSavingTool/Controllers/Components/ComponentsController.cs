using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Builders.Interfaces;
using StarSavingTool.Components;

namespace StarSavingTool.Builders
{
    public class ComponentsController : IComponenSetting
    {
        internal IEnumerable<BaseSaveComponent> RegisteredComponents { get { return registeredComponents; } }
        private readonly List<BaseSaveComponent> registeredComponents;

        public ComponentsController()
        {
            registeredComponents = new();
        }

        public void RegisterComponent<T>() where T : BaseSaveComponent, new()
        {
            registeredComponents.Add(new T());
        }
    }
}
