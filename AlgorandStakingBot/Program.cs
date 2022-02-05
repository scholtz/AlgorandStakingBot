using Newtonsoft.Json;
using NLog;

var logger = LogManager.GetCurrentClassLogger();
logger.Info($"App started {DateTimeOffset.Now}");

var configText = File.ReadAllText("appsettings.json");
var configuration = JsonConvert.DeserializeObject<AlgorandStakingBot.Model.Configuration>(configText);
CancellationTokenSource cts = new CancellationTokenSource();
var StakingMonitor = new AlgorandStakingBot.StakingMonitor(configuration, cts.Token);
await StakingMonitor.Run();