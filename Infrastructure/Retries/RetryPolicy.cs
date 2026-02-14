Policy
  .Handle<Exception>()
  .WaitAndRetryAsync(new[]
  {
      TimeSpan.FromSeconds(1),
      TimeSpan.FromSeconds(2),
      TimeSpan.FromSeconds(4)
  });
