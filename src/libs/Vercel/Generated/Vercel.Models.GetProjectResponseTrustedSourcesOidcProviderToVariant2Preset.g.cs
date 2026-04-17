
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTrustedSourcesOidcProviderToVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseTrustedSourcesOidcProviderToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTrustedSourcesOidcProviderToVariant2Preset value)
        {
            return value switch
            {
                GetProjectResponseTrustedSourcesOidcProviderToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTrustedSourcesOidcProviderToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => GetProjectResponseTrustedSourcesOidcProviderToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}