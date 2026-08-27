
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetStorageStoresByIdResponseStoreStatus
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
    public static class GetStorageStoresByIdResponseStoreStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageStoresByIdResponseStoreStatus value)
        {
            return value switch
            {
                GetStorageStoresByIdResponseStoreStatus.Available => "available",
                GetStorageStoresByIdResponseStoreStatus.Error => "error",
                GetStorageStoresByIdResponseStoreStatus.Initializing => "initializing",
                GetStorageStoresByIdResponseStoreStatus.LimitsExceededSuspended => "limits-exceeded-suspended",
                GetStorageStoresByIdResponseStoreStatus.LimitsExceededSuspendedStoreCount => "limits-exceeded-suspended-store-count",
                GetStorageStoresByIdResponseStoreStatus.Onboarding => "onboarding",
                GetStorageStoresByIdResponseStoreStatus.Suspended => "suspended",
                GetStorageStoresByIdResponseStoreStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageStoresByIdResponseStoreStatus? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetStorageStoresByIdResponseStoreStatus.Available,
                "error" => GetStorageStoresByIdResponseStoreStatus.Error,
                "initializing" => GetStorageStoresByIdResponseStoreStatus.Initializing,
                "limits-exceeded-suspended" => GetStorageStoresByIdResponseStoreStatus.LimitsExceededSuspended,
                "limits-exceeded-suspended-store-count" => GetStorageStoresByIdResponseStoreStatus.LimitsExceededSuspendedStoreCount,
                "onboarding" => GetStorageStoresByIdResponseStoreStatus.Onboarding,
                "suspended" => GetStorageStoresByIdResponseStoreStatus.Suspended,
                "uninstalled" => GetStorageStoresByIdResponseStoreStatus.Uninstalled,
                _ => null,
            };
        }
    }
}