using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Builders;
using StarSavingTool.Streams;

namespace StarSavingTool.Manager
{
    public static class SaveFactory
    {
        public static async Task<SaveFile> CreateAsync<T>(string directory, string name) where T : BaseSaveBuilder, new()
        {
            BaseSaveBuilder builder = new T
            {
                Filename = name,
                BaseDirectory = directory
            };

            SaveFile result = await builder.BuildProcessAsync();
            return await Task.FromResult(result);
        }
    }
}
