
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2Preset value)
        {
            return value switch
            {
                UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}