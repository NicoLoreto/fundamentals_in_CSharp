namespace ASPWorker
{
    internal class FileData : IFileData
    {
        public async Task Create(string path, int n)
        {
            using (var sw = new StreamWriter(path))
            {
                await Task.Delay(1000);
                await sw.WriteAsync($"pato {n}");
            }
        }
    }
}
