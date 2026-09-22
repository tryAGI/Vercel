
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths. Legacy rows omit this field and callers fall back to existing `type` behavior.
    /// </summary>
    public enum UploadProjectAvatarResponseEnvItemVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Config,
        /// <summary>
        ///
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseEnvItemVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseEnvItemVisibility value)
        {
            return value switch
            {
                UploadProjectAvatarResponseEnvItemVisibility.Config => "config",
                UploadProjectAvatarResponseEnvItemVisibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseEnvItemVisibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => UploadProjectAvatarResponseEnvItemVisibility.Config,
                "secret" => UploadProjectAvatarResponseEnvItemVisibility.Secret,
                _ => null,
            };
        }
    }
}