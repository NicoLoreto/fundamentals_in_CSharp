namespace ASPWorker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private string _path = Directory.GetCurrentDirectory() + @"\Files\";
        private int _count = 0;

        private IFileData _fileData;

        public Worker(ILogger<Worker> logger, IFileData fileData)
        {
            _logger = logger;
            _fileData = fileData;   
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Se ejecutar� hasta que no se reciba una cancelaci�n.
            // Ejecutar tareas en segundo plano.
            int n = 0;
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    if (n < 10)
                    {
                        await _fileData.Create($"{_path}{_count++}.txt", n);
                        n++;
                    }
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
