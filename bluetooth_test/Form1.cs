using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace bluetooth_test
{
    public partial class Form1 : Form
    {
        private static string configFile = "C:\\Users\\admin\\source\\repos\\bluetooth_test\\bluetooth_test\\Settings.yaml";
        private static string logFile = "log.txt";
        private static BatteryBluetoothConfig config;
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            config = ReadConfig();
            bool isValidLicense = CheckLicense(config.LicenseKey);
            if(isValidLicense)
            {
                lbRead.Text = "Config successfully generated. Welcome back!";
            }else
            {
                lbRead.Text = "License Key is not available. You might need to purchase one.";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(configFile))
                {
                    var serializer = new SerializerBuilder()
                        .WithNamingConvention(PascalCaseNamingConvention.Instance)
                        .Build();
                    serializer.Serialize(writer, config);
                    lbSave.Text = "Successfully saved to Settings.yaml";
                }
            }
            catch (Exception ex)
            {
                lbSave.Text = "Failed to save to Settings.yaml";
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter("C:\\Users\\admin\\source\\repos\\bluetooth_test\\bluetooth_test\\settings.txt"))
                {
                    // Encrypt license key
                    config.LicenseKey = Encrypt(config.LicenseKey);

                    var serializer = new SerializerBuilder()
                        .WithNamingConvention(PascalCaseNamingConvention.Instance)
                        .Build();
                    serializer.Serialize(writer, config);
                    Console.WriteLine($"Configuration exported to settings.txt");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to export configuration to settings.txt: {ex.Message}");
            }
        }

        private void btObfuscate_Click(object sender, EventArgs e)
        {
            ObfuscateConfig(config);
        }

        static BatteryBluetoothConfig ReadConfig()
        {
            BatteryBluetoothConfig config = null;
            
            if (!File.Exists(configFile))
            {
                Console.WriteLine("Configuration file not found. Creating a new one...");
                config = new BatteryBluetoothConfig();
            }
            else
            {
                try
                {
                    using (var reader = new StreamReader(configFile))
                    {
                        var deserializer = new DeserializerBuilder()
                            .WithNamingConvention(PascalCaseNamingConvention.Instance)
                            .Build();
                        config = deserializer.Deserialize<BatteryBluetoothConfig>(reader);
                        Console.WriteLine("Configuration read from Settings.yaml");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to read configuration from Settings.yaml: {ex.Message}");
                    config = new BatteryBluetoothConfig(); // Return a default config object
                }
            }

            return config;
        }

        
        


        static void UpdateConfig(BatteryBluetoothConfig config, bool batterySaverMode, bool bluetoothEnabled, string bluetoothDeviceName)
        {
            config.BatterySaverMode = batterySaverMode;
            config.BluetoothEnabled = bluetoothEnabled;
            config.BluetoothDeviceName = bluetoothDeviceName;

            Console.WriteLine("Configuration updated");
        }

        static bool CheckLicense(string licenseKey)
        {
            // Perform license validation logic here
            // For example, validate against a license server or a local database

            // Placeholder logic: Assume license is valid if license key is not empty
            return !string.IsNullOrEmpty(licenseKey);
        }

        static void CreateLogFile()
        {
            try
            {
                // Create log file if not exists
                if (!File.Exists(logFile))
                {
                    File.Create(logFile).Close();
                    Console.WriteLine($"Log file created: {logFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to create log file: {ex.Message}");
            }
        }

        static void ObfuscateConfig(BatteryBluetoothConfig config)
        {
            // Obfuscate sensitive information, such as license key
            config.LicenseKey = ObfuscateString(config.LicenseKey);
        }

        static string ObfuscateString(string input)
        {
            // Placeholder logic: Obfuscate string by replacing characters with '*'
            char[] obfuscated = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                obfuscated[i] = '*';
            }

            return new string(obfuscated);
        }

        static string Encrypt(string input)
        {
            // Placeholder logic: Encrypt string using custom encryption algorithm
            // Note: This is a simplified example and should not be used in production
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(input);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= 0x55;
            }
            return Convert.ToBase64String(bytes);
        }
    }
}