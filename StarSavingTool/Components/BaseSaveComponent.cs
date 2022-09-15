#pragma warning disable CS8618

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Streams;

namespace StarSavingTool.Components
{
    public abstract class BaseSaveComponent
    {
        protected SaveFile Instance { get; private set; }

        internal async Task BuildAsync(SaveFile file)
        {
            Instance = file;

            await SavingProcessAsync();
        }

        protected abstract Task SavingProcessAsync();
    }
}
