
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Defines the installation type. - 'external' integrations are installed via the existing integrations flow - 'marketplace' integrations are natively installed: - when accepting the TOS of a partner during the store creation process - if undefined, assume 'external'
    /// </summary>
    public enum GetConfigurationsResponseVariant2ItemInstallationType
    {
        /// <summary>
        /// - when accepting the TOS of a partner during the store creation process - if undefined, assume 'external'
        /// </summary>
        External,
        /// <summary>
        /// - when accepting the TOS of a partner during the store creation process - if undefined, assume 'external'
        /// </summary>
        Marketplace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationsResponseVariant2ItemInstallationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant2ItemInstallationType value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant2ItemInstallationType.External => "external",
                GetConfigurationsResponseVariant2ItemInstallationType.Marketplace => "marketplace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant2ItemInstallationType? ToEnum(string value)
        {
            return value switch
            {
                "external" => GetConfigurationsResponseVariant2ItemInstallationType.External,
                "marketplace" => GetConfigurationsResponseVariant2ItemInstallationType.Marketplace,
                _ => null,
            };
        }
    }
}