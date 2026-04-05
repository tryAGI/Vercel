
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The configuration status. Optional. If not defined, assume 'ready'.
    /// </summary>
    public enum GetConfigurationsResponseVariant1ItemStatus
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
    public static class GetConfigurationsResponseVariant1ItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant1ItemStatus value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant1ItemStatus.Error => "error",
                GetConfigurationsResponseVariant1ItemStatus.Onboarding => "onboarding",
                GetConfigurationsResponseVariant1ItemStatus.Pending => "pending",
                GetConfigurationsResponseVariant1ItemStatus.Ready => "ready",
                GetConfigurationsResponseVariant1ItemStatus.Resumed => "resumed",
                GetConfigurationsResponseVariant1ItemStatus.Suspended => "suspended",
                GetConfigurationsResponseVariant1ItemStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant1ItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConfigurationsResponseVariant1ItemStatus.Error,
                "onboarding" => GetConfigurationsResponseVariant1ItemStatus.Onboarding,
                "pending" => GetConfigurationsResponseVariant1ItemStatus.Pending,
                "ready" => GetConfigurationsResponseVariant1ItemStatus.Ready,
                "resumed" => GetConfigurationsResponseVariant1ItemStatus.Resumed,
                "suspended" => GetConfigurationsResponseVariant1ItemStatus.Suspended,
                "uninstalled" => GetConfigurationsResponseVariant1ItemStatus.Uninstalled,
                _ => null,
            };
        }
    }
}