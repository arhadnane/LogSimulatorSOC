using System;
using Xunit;
using LogSimulatorSOC;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace LogSimulatorSOC.Tests
{
    public class LogGeneratorTests
    {
        [Fact]
        public void GenerateNormalSystemLog_ShouldReturnExpectedLog()
        {
            // Arrange
            // (No setup needed for this test)

            // Act
            string log = LogSimulatorSOC.GenerateNormalSystemLog();

            // Assert
            Assert.Contains("[INFO]", log);
            Assert.Contains("Process \"explorer.exe\" started successfully.", log);
        }

        [Fact]
        public void GenerateNormalNetworkLog_ShouldReturnExpectedLog()
        {
            // Act
            string log = LogSimulatorSOC.GenerateNormalNetworkLog();

            // Assert
            Assert.Contains("[INFO]", log);
            Assert.Contains("Network connection established:", log);
        }

        [Fact]
        public void GenerateBruteForceAttemptLog_ShouldReturnExpectedLog()
        {
            // Act
            string log = LogSimulatorSOC.GenerateBruteForceAttemptLog();

            // Assert
            Assert.Contains("[WARNING]", log);
            Assert.Contains("Brute force login attempt detected.", log);
        }

        [Fact]
        public void GeneratePortScanLog_ShouldReturnExpectedLog()
        {
            // Act
            string log = LogSimulatorSOC.GeneratePortScanLog();

            // Assert
            Assert.Contains("[WARNING]", log);
            Assert.Contains("Port scan detected from", log);
        }

        [Fact]
        public void GenerateFraudulentSSHConnectionLog_ShouldReturnExpectedLog()
        {
            // Act
            string log = LogSimulatorSOC.GenerateFraudulentSSHConnectionLog();

            // Assert
            Assert.Contains("[CRITICAL]", log);
            Assert.Contains("Unauthorized SSH connection attempt detected from", log);
        }
    }
}
