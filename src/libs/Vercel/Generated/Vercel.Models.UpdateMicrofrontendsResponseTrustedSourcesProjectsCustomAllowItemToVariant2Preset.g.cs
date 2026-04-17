
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}