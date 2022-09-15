using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using StarSavingTool.Components;

namespace StarSavingTool.Console
{
    public class AchiviementsComponent : BaseSaveComponent
    {
        private Dictionary<string, Achiviment> achiviements = new()
        {
            ["001"] = new("One", "001", false),
            ["002"] = new("Two", "002", true),
            ["003"] = new("Three", "003", false),
            ["004"] = new("Four", "004", true),
            ["005"] = new("Five", "005", false),
            ["006"] = new("Six", "006", false),
            ["007"] = new("Seven", "007", true),
            ["008"] = new("Eight", "008", false),
            ["009"] = new("Nine", "009", true),
        };

        protected override async Task SavingProcessAsync()
        {
            foreach (var achiviement in achiviements)
            {
                await Instance.CreateAsync($"/Achiviements/{achiviement.Value.Id}.json", JsonSerializer.Serialize<Achiviment>(achiviement.Value, new JsonSerializerOptions()
                {
                    IncludeFields = true,
                    WriteIndented = true,
                }));
            }

            await Task.CompletedTask;
        }
    }

    public struct Achiviment
    {
        public string Name;
        public string Id;
        public bool IsCompleted;

        public Achiviment(string name, string id, bool isCompleted)
        {
            Name = name;
            Id = id;
            IsCompleted = isCompleted;
        }
    }
}
