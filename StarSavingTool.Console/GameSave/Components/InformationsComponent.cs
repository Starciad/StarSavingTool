using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Components;

namespace StarSavingTool.Console
{
    public class InformationsComponent : BaseSaveComponent
    {
        protected override async Task SavingProcessAsync()
        {
            await Instance.CreateAsync("/Informations/Information.json", String.Empty);

            await Task.CompletedTask;
        }
    }
}
