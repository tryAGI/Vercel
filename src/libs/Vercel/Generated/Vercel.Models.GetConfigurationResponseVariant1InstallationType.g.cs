
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Defines the installation type. - 'external' integrations are installed via the existing integrations flow - 'marketplace' integrations are natively installed: - when accepting the TOS of a partner during the store creation process - if undefined, assume 'external'
    /// </summary>
    public enum GetConfigurationResponseVariant1InstallationType
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
    public static class GetConfigurationResponseVariant1InstallationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1InstallationType value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1InstallationType.External => "external",
                GetConfigurationResponseVariant1InstallationType.Marketplace => "marketplace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1InstallationType? ToEnum(string value)
        {
            return value switch
            {
                "external" => GetConfigurationResponseVariant1InstallationType.External,
                "marketplace" => GetConfigurationResponseVariant1InstallationType.Marketplace,
                _ => null,
            };
        }
    }
}