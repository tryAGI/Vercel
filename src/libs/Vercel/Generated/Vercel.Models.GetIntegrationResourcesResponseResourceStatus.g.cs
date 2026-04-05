
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current status of the resource
    /// </summary>
    public enum GetIntegrationResourcesResponseResourceStatus
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
    public static class GetIntegrationResourcesResponseResourceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationResourcesResponseResourceStatus value)
        {
            return value switch
            {
                GetIntegrationResourcesResponseResourceStatus.Error => "error",
                GetIntegrationResourcesResponseResourceStatus.Onboarding => "onboarding",
                GetIntegrationResourcesResponseResourceStatus.Pending => "pending",
                GetIntegrationResourcesResponseResourceStatus.Ready => "ready",
                GetIntegrationResourcesResponseResourceStatus.Resumed => "resumed",
                GetIntegrationResourcesResponseResourceStatus.Suspended => "suspended",
                GetIntegrationResourcesResponseResourceStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationResourcesResponseResourceStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetIntegrationResourcesResponseResourceStatus.Error,
                "onboarding" => GetIntegrationResourcesResponseResourceStatus.Onboarding,
                "pending" => GetIntegrationResourcesResponseResourceStatus.Pending,
                "ready" => GetIntegrationResourcesResponseResourceStatus.Ready,
                "resumed" => GetIntegrationResourcesResponseResourceStatus.Resumed,
                "suspended" => GetIntegrationResourcesResponseResourceStatus.Suspended,
                "uninstalled" => GetIntegrationResourcesResponseResourceStatus.Uninstalled,
                _ => null,
            };
        }
    }
}