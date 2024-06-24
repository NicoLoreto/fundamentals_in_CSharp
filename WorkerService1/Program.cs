using WorkerService1;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>()
    // uso de inyección de dependencia, se le da la reponsabilidad al
    // framework de instanciar objetos singleton, una instancia para toda la aplicación.
    .AddSingleton<IFileData, FileData>();

var host = builder.Build();
host.Run();
