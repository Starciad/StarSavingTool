using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Components;

namespace StarSavingTool.Builders.Interfaces
{
    public interface IComponenSetting
    {
        void RegisterComponent<T>() where T : BaseSaveComponent, new();
    }
}
