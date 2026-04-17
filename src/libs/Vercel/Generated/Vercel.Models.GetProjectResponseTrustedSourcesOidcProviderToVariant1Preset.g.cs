
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTrustedSourcesOidcProviderToVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseTrustedSourcesOidcProviderToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTrustedSourcesOidcProviderToVariant1Preset value)
        {
            return value switch
            {
                GetProjectResponseTrustedSourcesOidcProviderToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTrustedSourcesOidcProviderToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => GetProjectResponseTrustedSourcesOidcProviderToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}