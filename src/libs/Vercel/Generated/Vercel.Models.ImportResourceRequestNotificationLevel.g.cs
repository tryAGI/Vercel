
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportResourceRequestNotificationLevel
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
    public static class ImportResourceRequestNotificationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportResourceRequestNotificationLevel value)
        {
            return value switch
            {
                ImportResourceRequestNotificationLevel.Error => "error",
                ImportResourceRequestNotificationLevel.Info => "info",
                ImportResourceRequestNotificationLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportResourceRequestNotificationLevel? ToEnum(string value)
        {
            return value switch
            {
                "error" => ImportResourceRequestNotificationLevel.Error,
                "info" => ImportResourceRequestNotificationLevel.Info,
                "warn" => ImportResourceRequestNotificationLevel.Warn,
                _ => null,
            };
        }
    }
}