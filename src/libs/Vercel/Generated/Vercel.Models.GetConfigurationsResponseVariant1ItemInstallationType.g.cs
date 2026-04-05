
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Defines the installation type. - 'external' integrations are installed via the existing integrations flow - 'marketplace' integrations are natively installed: - when accepting the TOS of a partner during the store creation process - if undefined, assume 'external'
    /// </summary>
    public enum GetConfigurationsResponseVariant1ItemInstallationType
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
    public static class GetConfigurationsResponseVariant1ItemInstallationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant1ItemInstallationType value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant1ItemInstallationType.External => "external",
                GetConfigurationsResponseVariant1ItemInstallationType.Marketplace => "marketplace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant1ItemInstallationType? ToEnum(string value)
        {
            return value switch
            {
                "external" => GetConfigurationsResponseVariant1ItemInstallationType.External,
                "marketplace" => GetConfigurationsResponseVariant1ItemInstallationType.Marketplace,
                _ => null,
            };
        }
    }
}