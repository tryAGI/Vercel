
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94938587734e5f57OidcProviderToVariant1Preset
    {
        /// <summary>
        ///
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared94938587734e5f57OidcProviderToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94938587734e5f57OidcProviderToVariant1Preset value)
        {
            return value switch
            {
                AutoSDKShared94938587734e5f57OidcProviderToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94938587734e5f57OidcProviderToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => AutoSDKShared94938587734e5f57OidcProviderToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}