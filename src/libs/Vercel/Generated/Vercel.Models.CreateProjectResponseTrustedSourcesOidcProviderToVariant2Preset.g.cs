
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTrustedSourcesOidcProviderToVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseTrustedSourcesOidcProviderToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTrustedSourcesOidcProviderToVariant2Preset value)
        {
            return value switch
            {
                CreateProjectResponseTrustedSourcesOidcProviderToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTrustedSourcesOidcProviderToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => CreateProjectResponseTrustedSourcesOidcProviderToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}