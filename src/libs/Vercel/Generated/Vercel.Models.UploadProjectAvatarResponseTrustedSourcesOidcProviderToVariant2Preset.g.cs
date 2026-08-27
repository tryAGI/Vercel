
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2Preset
    {
        /// <summary>
        ///
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2Preset value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}