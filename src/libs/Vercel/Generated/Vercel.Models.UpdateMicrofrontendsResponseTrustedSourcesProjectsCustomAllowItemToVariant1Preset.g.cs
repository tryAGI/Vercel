
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}