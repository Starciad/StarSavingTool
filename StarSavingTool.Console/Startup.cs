using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Manager;

namespace StarSavingTool.Console
{
    public class Startup
    {
        public async Task RunAsync()
        {
            await SaveFactory.CreateAsync<GameSaveFile>(@$"{Environment.SpecialFolder.MyDocuments}\Ex\GameSave\", "SaveTest");
        }
    }
}
