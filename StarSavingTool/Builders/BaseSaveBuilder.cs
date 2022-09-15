#pragma warning disable CS8618

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Builders.Interfaces;
using StarSavingTool.Streams;

namespace StarSavingTool.Builders
{
    public abstract class BaseSaveBuilder
    {
        internal string Filename { get; set; }
        internal string BaseDirectory { get; set; }
        internal string FullPath { get { return Path.Combine(BaseDirectory, Filename); } }

        internal readonly ComponentsController componentSetting;

        public BaseSaveBuilder()
        {
            componentSetting = new();
        }

        internal async Task<SaveFile> BuildProcessAsync()
        {
            CreateComponents(componentSetting);

            SaveFile saveResult = new(this);
            await saveResult.BuildAsync();

            return await Task.FromResult(saveResult);
        }

        protected abstract void CreateComponents(IComponenSetting setting);
    }
}
