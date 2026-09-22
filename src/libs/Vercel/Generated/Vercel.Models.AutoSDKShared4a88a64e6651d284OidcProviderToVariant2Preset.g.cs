
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4a88a64e6651d284OidcProviderToVariant2Preset
    {
        /// <summary>
        ///
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared4a88a64e6651d284OidcProviderToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4a88a64e6651d284OidcProviderToVariant2Preset value)
        {
            return value switch
            {
                AutoSDKShared4a88a64e6651d284OidcProviderToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4a88a64e6651d284OidcProviderToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => AutoSDKShared4a88a64e6651d284OidcProviderToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}