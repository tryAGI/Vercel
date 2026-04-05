
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetIntegrationResourcesResponseResourceNotificationLevel
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
    public static class GetIntegrationResourcesResponseResourceNotificationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationResourcesResponseResourceNotificationLevel value)
        {
            return value switch
            {
                GetIntegrationResourcesResponseResourceNotificationLevel.Error => "error",
                GetIntegrationResourcesResponseResourceNotificationLevel.Info => "info",
                GetIntegrationResourcesResponseResourceNotificationLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationResourcesResponseResourceNotificationLevel? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetIntegrationResourcesResponseResourceNotificationLevel.Error,
                "info" => GetIntegrationResourcesResponseResourceNotificationLevel.Info,
                "warn" => GetIntegrationResourcesResponseResourceNotificationLevel.Warn,
                _ => null,
            };
        }
    }
}