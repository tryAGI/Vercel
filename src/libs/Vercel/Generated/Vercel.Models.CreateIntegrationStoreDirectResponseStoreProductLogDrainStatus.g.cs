
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductLogDrainStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus.Disabled => "disabled",
                CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus.Disabled,
                "enabled" => CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus.Enabled,
                _ => null,
            };
        }
    }
}