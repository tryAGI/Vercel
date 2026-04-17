
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToPreset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToPreset value)
        {
            return value switch
            {
                UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToPreset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToPreset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToPreset.AllCustom,
                _ => null,
            };
        }
    }
}