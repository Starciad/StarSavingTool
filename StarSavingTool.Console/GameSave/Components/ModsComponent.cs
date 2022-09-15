using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Components;

namespace StarSavingTool.Console
{
    public class ModsComponent : BaseSaveComponent
    {
        protected override async Task SavingProcessAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    await Instance.CreateAsync($"/Mods/Mod{i}/Info{k}.json", String.Empty);
                    await Instance.CreateAsync($"/Mods/Mod{i}/temp{k}.json", String.Empty);
                    await Instance.CreateAsync($"/Mods/Mod{i}/out{k}.json", String.Empty);
                }
            }

            await Task.CompletedTask;
        }
    }
}
