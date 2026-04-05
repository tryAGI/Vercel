
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The configuration status. Optional. If not defined, assume 'ready'.
    /// </summary>
    public enum GetConfigurationsResponseVariant2ItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Onboarding,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Resumed,
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
    public static class GetConfigurationsResponseVariant2ItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant2ItemStatus value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant2ItemStatus.Error => "error",
                GetConfigurationsResponseVariant2ItemStatus.Onboarding => "onboarding",
                GetConfigurationsResponseVariant2ItemStatus.Pending => "pending",
                GetConfigurationsResponseVariant2ItemStatus.Ready => "ready",
                GetConfigurationsResponseVariant2ItemStatus.Resumed => "resumed",
                GetConfigurationsResponseVariant2ItemStatus.Suspended => "suspended",
                GetConfigurationsResponseVariant2ItemStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant2ItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConfigurationsResponseVariant2ItemStatus.Error,
                "onboarding" => GetConfigurationsResponseVariant2ItemStatus.Onboarding,
                "pending" => GetConfigurationsResponseVariant2ItemStatus.Pending,
                "ready" => GetConfigurationsResponseVariant2ItemStatus.Ready,
                "resumed" => GetConfigurationsResponseVariant2ItemStatus.Resumed,
                "suspended" => GetConfigurationsResponseVariant2ItemStatus.Suspended,
                "uninstalled" => GetConfigurationsResponseVariant2ItemStatus.Uninstalled,
                _ => null,
            };
        }
    }
}