
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        LimitsExceededSuspended,
        /// <summary>
        /// 
        /// </summary>
        LimitsExceededSuspendedStoreCount,
        /// <summary>
        /// 
        /// </summary>
        Onboarding,
        /// <summary>
        /// 
        /// </summary>
        Suspended,
        /// <summary>
        /// 
        /// </summary>
        Uninstalled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreStatus value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreStatus.Available => "available",
                CreateIntegrationStoreDirectResponseStoreStatus.Error => "error",
                CreateIntegrationStoreDirectResponseStoreStatus.Initializing => "initializing",
                CreateIntegrationStoreDirectResponseStoreStatus.LimitsExceededSuspended => "limits-exceeded-suspended",
                CreateIntegrationStoreDirectResponseStoreStatus.LimitsExceededSuspendedStoreCount => "limits-exceeded-suspended-store-count",
                CreateIntegrationStoreDirectResponseStoreStatus.Onboarding => "onboarding",
                CreateIntegrationStoreDirectResponseStoreStatus.Suspended => "suspended",
                CreateIntegrationStoreDirectResponseStoreStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreStatus? ToEnum(string value)
        {
            return value switch
            {
                "available" => CreateIntegrationStoreDirectResponseStoreStatus.Available,
                "error" => CreateIntegrationStoreDirectResponseStoreStatus.Error,
                "initializing" => CreateIntegrationStoreDirectResponseStoreStatus.Initializing,
                "limits-exceeded-suspended" => CreateIntegrationStoreDirectResponseStoreStatus.LimitsExceededSuspended,
                "limits-exceeded-suspended-store-count" => CreateIntegrationStoreDirectResponseStoreStatus.LimitsExceededSuspendedStoreCount,
                "onboarding" => CreateIntegrationStoreDirectResponseStoreStatus.Onboarding,
                "suspended" => CreateIntegrationStoreDirectResponseStoreStatus.Suspended,
                "uninstalled" => CreateIntegrationStoreDirectResponseStoreStatus.Uninstalled,
                _ => null,
            };
        }
    }
}