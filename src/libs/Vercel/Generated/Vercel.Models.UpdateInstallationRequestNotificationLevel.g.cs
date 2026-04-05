
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateInstallationRequestNotificationLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInstallationRequestNotificationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInstallationRequestNotificationLevel value)
        {
            return value switch
            {
                UpdateInstallationRequestNotificationLevel.Error => "error",
                UpdateInstallationRequestNotificationLevel.Info => "info",
                UpdateInstallationRequestNotificationLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInstallationRequestNotificationLevel? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateInstallationRequestNotificationLevel.Error,
                "info" => UpdateInstallationRequestNotificationLevel.Info,
                "warn" => UpdateInstallationRequestNotificationLevel.Warn,
                _ => null,
            };
        }
    }
}