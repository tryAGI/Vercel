
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset
    {
        /// <summary>
        ///
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared31ad55d5a9d0e802ItemFromVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset value)
        {
            return value switch
            {
                AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}