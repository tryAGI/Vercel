
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProviderToVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProviderToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProviderToVariant1Preset value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProviderToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProviderToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProviderToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}