
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant2Preset value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}