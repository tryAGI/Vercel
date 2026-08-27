
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset
    {
        /// <summary>
        ///
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}