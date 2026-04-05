
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The configuration status. Optional. If not defined, assume 'ready'.
    /// </summary>
    public enum GetConfigurationResponseVariant3Status
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
    public static class GetConfigurationResponseVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant3Status value)
        {
            return value switch
            {
                GetConfigurationResponseVariant3Status.Error => "error",
                GetConfigurationResponseVariant3Status.Onboarding => "onboarding",
                GetConfigurationResponseVariant3Status.Pending => "pending",
                GetConfigurationResponseVariant3Status.Ready => "ready",
                GetConfigurationResponseVariant3Status.Resumed => "resumed",
                GetConfigurationResponseVariant3Status.Suspended => "suspended",
                GetConfigurationResponseVariant3Status.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConfigurationResponseVariant3Status.Error,
                "onboarding" => GetConfigurationResponseVariant3Status.Onboarding,
                "pending" => GetConfigurationResponseVariant3Status.Pending,
                "ready" => GetConfigurationResponseVariant3Status.Ready,
                "resumed" => GetConfigurationResponseVariant3Status.Resumed,
                "suspended" => GetConfigurationResponseVariant3Status.Suspended,
                "uninstalled" => GetConfigurationResponseVariant3Status.Uninstalled,
                _ => null,
            };
        }
    }
}