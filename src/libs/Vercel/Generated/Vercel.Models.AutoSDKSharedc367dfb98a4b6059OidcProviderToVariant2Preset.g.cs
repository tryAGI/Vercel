
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc367dfb98a4b6059OidcProviderToVariant2Preset
    {
        /// <summary>
        ///
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc367dfb98a4b6059OidcProviderToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc367dfb98a4b6059OidcProviderToVariant2Preset value)
        {
            return value switch
            {
                AutoSDKSharedc367dfb98a4b6059OidcProviderToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc367dfb98a4b6059OidcProviderToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => AutoSDKSharedc367dfb98a4b6059OidcProviderToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}