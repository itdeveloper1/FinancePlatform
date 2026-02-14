Log.Logger = new LoggerConfiguration()
    .Enrich.WithCorrelationId()
    .WriteTo.Console()
    .CreateLogger();
