
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset
    {
        /// <summary>
        ///
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}