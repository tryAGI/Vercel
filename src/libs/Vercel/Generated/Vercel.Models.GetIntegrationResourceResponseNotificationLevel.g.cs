
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetIntegrationResourceResponseNotificationLevel
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
    public static class GetIntegrationResourceResponseNotificationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationResourceResponseNotificationLevel value)
        {
            return value switch
            {
                GetIntegrationResourceResponseNotificationLevel.Error => "error",
                GetIntegrationResourceResponseNotificationLevel.Info => "info",
                GetIntegrationResourceResponseNotificationLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationResourceResponseNotificationLevel? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetIntegrationResourceResponseNotificationLevel.Error,
                "info" => GetIntegrationResourceResponseNotificationLevel.Info,
                "warn" => GetIntegrationResourceResponseNotificationLevel.Warn,
                _ => null,
            };
        }
    }
}