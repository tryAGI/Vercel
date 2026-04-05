
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current status of the resource
    /// </summary>
    public enum GetIntegrationResourceResponseStatus
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
    public static class GetIntegrationResourceResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationResourceResponseStatus value)
        {
            return value switch
            {
                GetIntegrationResourceResponseStatus.Error => "error",
                GetIntegrationResourceResponseStatus.Onboarding => "onboarding",
                GetIntegrationResourceResponseStatus.Pending => "pending",
                GetIntegrationResourceResponseStatus.Ready => "ready",
                GetIntegrationResourceResponseStatus.Resumed => "resumed",
                GetIntegrationResourceResponseStatus.Suspended => "suspended",
                GetIntegrationResourceResponseStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationResourceResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetIntegrationResourceResponseStatus.Error,
                "onboarding" => GetIntegrationResourceResponseStatus.Onboarding,
                "pending" => GetIntegrationResourceResponseStatus.Pending,
                "ready" => GetIntegrationResourceResponseStatus.Ready,
                "resumed" => GetIntegrationResourceResponseStatus.Resumed,
                "suspended" => GetIntegrationResourceResponseStatus.Suspended,
                "uninstalled" => GetIntegrationResourceResponseStatus.Uninstalled,
                _ => null,
            };
        }
    }
}