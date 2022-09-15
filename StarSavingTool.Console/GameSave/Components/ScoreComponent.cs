using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Components;

namespace StarSavingTool.Console
{
    public class ScoreComponent : BaseSaveComponent
    {
        protected override async Task SavingProcessAsync()
        {
            await Instance.CreateAsync($"/Score/", String.Empty);
            await Task.CompletedTask;
        }
    }
}
