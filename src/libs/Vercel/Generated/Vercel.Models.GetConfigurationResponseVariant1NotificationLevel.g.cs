
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant1NotificationLevel
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
    public static class GetConfigurationResponseVariant1NotificationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1NotificationLevel value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1NotificationLevel.Error => "error",
                GetConfigurationResponseVariant1NotificationLevel.Info => "info",
                GetConfigurationResponseVariant1NotificationLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1NotificationLevel? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConfigurationResponseVariant1NotificationLevel.Error,
                "info" => GetConfigurationResponseVariant1NotificationLevel.Info,
                "warn" => GetConfigurationResponseVariant1NotificationLevel.Warn,
                _ => null,
            };
        }
    }
}