
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The configuration status. Optional. If not defined, assume 'ready'.
    /// </summary>
    public enum GetConfigurationResponseVariant2Status
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
    public static class GetConfigurationResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant2Status value)
        {
            return value switch
            {
                GetConfigurationResponseVariant2Status.Error => "error",
                GetConfigurationResponseVariant2Status.Onboarding => "onboarding",
                GetConfigurationResponseVariant2Status.Pending => "pending",
                GetConfigurationResponseVariant2Status.Ready => "ready",
                GetConfigurationResponseVariant2Status.Resumed => "resumed",
                GetConfigurationResponseVariant2Status.Suspended => "suspended",
                GetConfigurationResponseVariant2Status.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConfigurationResponseVariant2Status.Error,
                "onboarding" => GetConfigurationResponseVariant2Status.Onboarding,
                "pending" => GetConfigurationResponseVariant2Status.Pending,
                "ready" => GetConfigurationResponseVariant2Status.Ready,
                "resumed" => GetConfigurationResponseVariant2Status.Resumed,
                "suspended" => GetConfigurationResponseVariant2Status.Suspended,
                "uninstalled" => GetConfigurationResponseVariant2Status.Uninstalled,
                _ => null,
            };
        }
    }
}