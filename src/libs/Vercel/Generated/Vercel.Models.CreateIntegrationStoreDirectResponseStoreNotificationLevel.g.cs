
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreNotificationLevel
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
    public static class CreateIntegrationStoreDirectResponseStoreNotificationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreNotificationLevel value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreNotificationLevel.Error => "error",
                CreateIntegrationStoreDirectResponseStoreNotificationLevel.Info => "info",
                CreateIntegrationStoreDirectResponseStoreNotificationLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreNotificationLevel? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateIntegrationStoreDirectResponseStoreNotificationLevel.Error,
                "info" => CreateIntegrationStoreDirectResponseStoreNotificationLevel.Info,
                "warn" => CreateIntegrationStoreDirectResponseStoreNotificationLevel.Warn,
                _ => null,
            };
        }
    }
}