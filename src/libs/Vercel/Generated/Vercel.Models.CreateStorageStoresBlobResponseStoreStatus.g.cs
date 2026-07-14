
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateStorageStoresBlobResponseStoreStatus
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
    public static class CreateStorageStoresBlobResponseStoreStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStorageStoresBlobResponseStoreStatus value)
        {
            return value switch
            {
                CreateStorageStoresBlobResponseStoreStatus.Available => "available",
                CreateStorageStoresBlobResponseStoreStatus.Error => "error",
                CreateStorageStoresBlobResponseStoreStatus.Initializing => "initializing",
                CreateStorageStoresBlobResponseStoreStatus.LimitsExceededSuspended => "limits-exceeded-suspended",
                CreateStorageStoresBlobResponseStoreStatus.LimitsExceededSuspendedStoreCount => "limits-exceeded-suspended-store-count",
                CreateStorageStoresBlobResponseStoreStatus.Onboarding => "onboarding",
                CreateStorageStoresBlobResponseStoreStatus.Suspended => "suspended",
                CreateStorageStoresBlobResponseStoreStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStorageStoresBlobResponseStoreStatus? ToEnum(string value)
        {
            return value switch
            {
                "available" => CreateStorageStoresBlobResponseStoreStatus.Available,
                "error" => CreateStorageStoresBlobResponseStoreStatus.Error,
                "initializing" => CreateStorageStoresBlobResponseStoreStatus.Initializing,
                "limits-exceeded-suspended" => CreateStorageStoresBlobResponseStoreStatus.LimitsExceededSuspended,
                "limits-exceeded-suspended-store-count" => CreateStorageStoresBlobResponseStoreStatus.LimitsExceededSuspendedStoreCount,
                "onboarding" => CreateStorageStoresBlobResponseStoreStatus.Onboarding,
                "suspended" => CreateStorageStoresBlobResponseStoreStatus.Suspended,
                "uninstalled" => CreateStorageStoresBlobResponseStoreStatus.Uninstalled,
                _ => null,
            };
        }
    }
}