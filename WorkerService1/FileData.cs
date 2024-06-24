﻿namespace WorkerService1
{
    internal class FileData : IFileData
    {
        public async Task Create(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                await Task.Delay(1000);
                await sw.WriteAsync("pato");
            }
        }
    }
}
