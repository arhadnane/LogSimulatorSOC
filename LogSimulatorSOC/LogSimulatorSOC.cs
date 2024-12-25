using Serilog.Core;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSimulatorSOC
{
    public class LogSimulatorSOC
    {
        public static void GenerateLogsSOC()
        {
            // Configure Serilog for log generation
            Logger logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/simulator.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Console.WriteLine("Simulateur de génération de logs pour SOC démarré.");
            Console.WriteLine("Appuyez sur Ctrl + C pour arrêter le simulateur.");

            // List of log templates for simulation
            var logTemplates = new List<Func<string>>
            {
                GenerateNormalSystemLog,
                GenerateNormalNetworkLog,
                GenerateBruteForceAttemptLog,
                GeneratePortScanLog,
                GenerateFraudulentSSHConnectionLog
            };

            var random = new Random();

            // Infinite loop to generate logs
            while (true)
            {
                try
                {
                    // Randomly select a log type to simulate
                    var logGenerator = logTemplates[random.Next(logTemplates.Count)];

                    // Generate and log the event
                    string logMessage = logGenerator();
                    logger.Information(logMessage);

                    // Wait for a short period before generating the next log
                    Thread.Sleep(random.Next(500, 3000)); // 0.5 to 3 seconds
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "An error occurred while generating logs.");
                }
            }
        }

        public static string GenerateNormalSystemLog()
        {
            return $"[INFO] [{DateTime.UtcNow}] Process \"explorer.exe\" started successfully.";
        }

        public static string GenerateNormalNetworkLog()
        {
            return $"[INFO] [{DateTime.UtcNow}] Network connection established: 192.168.1.10 -> 93.184.216.34:443.";
        }

        public static string GenerateBruteForceAttemptLog()
        {
            var random = new Random();
            var username = new[] { "admin", "user", "test" }[random.Next(3)];
            return $"[WARNING] [{DateTime.UtcNow}] Brute force login attempt detected. Username: {username}, Source IP: 192.168.1.{random.Next(100, 255)}.";
        }

        public static string GeneratePortScanLog()
        {
            var random = new Random();
            var sourceIP = $"192.168.1.{random.Next(100, 255)}";
            var destinationIP = $"10.0.0.{random.Next(1, 255)}";
            return $"[WARNING] [{DateTime.UtcNow}] Port scan detected from {sourceIP} to {destinationIP}.";
        }

        public static string GenerateFraudulentSSHConnectionLog()
        {
            var random = new Random();
            var sourceIP = $"192.168.1.{random.Next(100, 255)}";
            return $"[CRITICAL] [{DateTime.UtcNow}] Unauthorized SSH connection attempt detected from {sourceIP}.";
        }
    }
}
