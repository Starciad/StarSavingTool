using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using StarSavingTool.Components;

namespace StarSavingTool.Console
{
    public class HeaderComponent : BaseSaveComponent
    {
        protected override async Task SavingProcessAsync()
        {
            await BuildHeader();
            await BuildInformations();

            await Task.CompletedTask;
        }

        private async Task BuildHeader()
        {
            string result = JsonSerializer.Serialize<SaveHeader>(new(), new JsonSerializerOptions()
            {
                IncludeFields = true,
                WriteIndented = true,
            });
            await Instance.CreateAsync("/Header.json", result);
        }

        private async Task BuildInformations()
        {
            string result = JsonSerializer.Serialize<SaveInformations>(new(), new JsonSerializerOptions()
            {
                IncludeFields = true,
                WriteIndented = true,
            });
            await Instance.CreateAsync("/Informations.json", result);
        }
    }
}
