
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UploadProjectAvatarResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}