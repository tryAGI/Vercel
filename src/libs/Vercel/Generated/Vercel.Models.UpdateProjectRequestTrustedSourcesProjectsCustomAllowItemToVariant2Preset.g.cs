
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2Preset value)
        {
            return value switch
            {
                UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}