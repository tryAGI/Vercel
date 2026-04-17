
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromPreset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromPreset value)
        {
            return value switch
            {
                UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromPreset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromPreset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromPreset.AllCustom,
                _ => null,
            };
        }
    }
}