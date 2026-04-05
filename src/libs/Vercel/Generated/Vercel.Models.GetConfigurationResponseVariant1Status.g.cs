
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The configuration status. Optional. If not defined, assume 'ready'.
    /// </summary>
    public enum GetConfigurationResponseVariant1Status
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
    public static class GetConfigurationResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1Status value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1Status.Error => "error",
                GetConfigurationResponseVariant1Status.Onboarding => "onboarding",
                GetConfigurationResponseVariant1Status.Pending => "pending",
                GetConfigurationResponseVariant1Status.Ready => "ready",
                GetConfigurationResponseVariant1Status.Resumed => "resumed",
                GetConfigurationResponseVariant1Status.Suspended => "suspended",
                GetConfigurationResponseVariant1Status.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConfigurationResponseVariant1Status.Error,
                "onboarding" => GetConfigurationResponseVariant1Status.Onboarding,
                "pending" => GetConfigurationResponseVariant1Status.Pending,
                "ready" => GetConfigurationResponseVariant1Status.Ready,
                "resumed" => GetConfigurationResponseVariant1Status.Resumed,
                "suspended" => GetConfigurationResponseVariant1Status.Suspended,
                "uninstalled" => GetConfigurationResponseVariant1Status.Uninstalled,
                _ => null,
            };
        }
    }
}