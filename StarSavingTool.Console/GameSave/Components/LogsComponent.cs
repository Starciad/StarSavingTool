using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Components;

namespace StarSavingTool.Console
{
    public class LogsComponent : BaseSaveComponent
    {
        protected override async Task SavingProcessAsync()
        {
            string timeString = DateTime.Now.ToString();
            timeString = timeString.Replace('/', '-');
            timeString = timeString.Replace(':', '-');

            for (int i = 0; i < 50; i++)
            {
                await Instance.CreateAsync($"/Logs/{timeString}{i}.txt", String.Empty);
            }

            await Task.CompletedTask;
        }
    }
}
