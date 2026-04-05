
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationsInstallationType
    {
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Marketplace,
        /// <summary>
        /// 
        /// </summary>
        Provisioning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationsInstallationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsInstallationType value)
        {
            return value switch
            {
                GetConfigurationsInstallationType.External => "external",
                GetConfigurationsInstallationType.Marketplace => "marketplace",
                GetConfigurationsInstallationType.Provisioning => "provisioning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsInstallationType? ToEnum(string value)
        {
            return value switch
            {
                "external" => GetConfigurationsInstallationType.External,
                "marketplace" => GetConfigurationsInstallationType.Marketplace,
                "provisioning" => GetConfigurationsInstallationType.Provisioning,
                _ => null,
            };
        }
    }
}