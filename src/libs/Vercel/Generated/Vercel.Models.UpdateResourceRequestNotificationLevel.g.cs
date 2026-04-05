
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateResourceRequestNotificationLevel
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
    public static class UpdateResourceRequestNotificationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResourceRequestNotificationLevel value)
        {
            return value switch
            {
                UpdateResourceRequestNotificationLevel.Error => "error",
                UpdateResourceRequestNotificationLevel.Info => "info",
                UpdateResourceRequestNotificationLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResourceRequestNotificationLevel? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateResourceRequestNotificationLevel.Error,
                "info" => UpdateResourceRequestNotificationLevel.Info,
                "warn" => UpdateResourceRequestNotificationLevel.Warn,
                _ => null,
            };
        }
    }
}