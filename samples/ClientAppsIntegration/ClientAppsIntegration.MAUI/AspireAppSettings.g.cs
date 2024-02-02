namespace ClientAppsIntegration.MAUI
{
    public static class AspireAppSettings
    {
        // TODO: Update to set correct settings here, same as set in environment variables for e.g. WPF & WinForms clients
        // Later will be generated.
        public static readonly Dictionary<string, string> Settings =
            new Dictionary<string, string>
        {
            ["SecretKey"] = "Dictionary MyKey Value",
            ["TransientFaultHandlingOptions:Enabled"] = bool.TrueString,
            ["TransientFaultHandlingOptions:AutoRetryDelay"] = "00:00:07",
            ["Logging:LogLevel:Default"] = "Warning"
        };
    }
}
