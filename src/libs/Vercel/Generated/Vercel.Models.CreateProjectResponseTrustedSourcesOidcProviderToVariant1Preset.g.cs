
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTrustedSourcesOidcProviderToVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseTrustedSourcesOidcProviderToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTrustedSourcesOidcProviderToVariant1Preset value)
        {
            return value switch
            {
                CreateProjectResponseTrustedSourcesOidcProviderToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTrustedSourcesOidcProviderToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => CreateProjectResponseTrustedSourcesOidcProviderToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}