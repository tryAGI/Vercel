
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2Preset value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}