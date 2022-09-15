using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using StarSavingTool.Builders;
using StarSavingTool.Components;

namespace StarSavingTool.Streams
{
    public sealed class SaveFile
    {
        private readonly BaseSaveBuilder currentInstance;
        private readonly DirectoryInfo directory;

        internal SaveFile(BaseSaveBuilder baseSaveBuilder)
        {
            currentInstance = baseSaveBuilder;

            if(Directory.Exists(currentInstance.FullPath))
                Directory.Delete(currentInstance.FullPath, true);

            this.directory = Directory.CreateDirectory(currentInstance.FullPath);
        }

        internal Task BuildAsync()
        {
            List<Task> tasks = new();
            foreach (BaseSaveComponent component in currentInstance.componentSetting.RegisteredComponents)
            {
                tasks.Add(Task.Run(() => component.BuildAsync(this)));
            }

            Task.WaitAll(tasks.ToArray());
            return Task.CompletedTask;
        }

        public async Task CreateAsync(string filename, string value)
        {
            string path = Path.Join(directory.FullName, filename);
            List<string> filenameParts = filename.Replace('/', Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar).ToList();

            DirectoryInfo current = directory;
            if (filenameParts.Count > 1)
            {
                for (int i = 0; i < (filenameParts.Count - 1); i++)
                {
                    current = Directory.CreateDirectory(Path.Join(current.FullName, filenameParts[i]));
                }
            }

            if (!Path.HasExtension(filenameParts[filenameParts.Count - 1]))
                return;

            using FileStream file = new(path, FileMode.CreateNew, FileAccess.ReadWrite);
            using StreamWriter writer = new(file);

            await writer.FlushAsync();
            await writer.WriteAsync(value);

            await Task.CompletedTask;
        }
    }
}
