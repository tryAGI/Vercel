
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreExternalResourceStatus
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
    public static class CreateIntegrationStoreDirectResponseStoreExternalResourceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreExternalResourceStatus value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Error => "error",
                CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Onboarding => "onboarding",
                CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Pending => "pending",
                CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Ready => "ready",
                CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Resumed => "resumed",
                CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Suspended => "suspended",
                CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreExternalResourceStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Error,
                "onboarding" => CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Onboarding,
                "pending" => CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Pending,
                "ready" => CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Ready,
                "resumed" => CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Resumed,
                "suspended" => CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Suspended,
                "uninstalled" => CreateIntegrationStoreDirectResponseStoreExternalResourceStatus.Uninstalled,
                _ => null,
            };
        }
    }
}