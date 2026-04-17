
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset value)
        {
            return value switch
            {
                UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}