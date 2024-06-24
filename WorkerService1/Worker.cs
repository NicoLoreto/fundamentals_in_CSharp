namespace WorkerService1
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
            // Se ejecutará hasta que no se reciba una cancelación.
            // Ejecutar tareas en segundo plano.
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    await _fileData.Create($"{_path}{_count++}.txt");
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
