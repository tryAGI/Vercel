
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseEnvItemTarget
    {
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseEnvItemTarget value)
        {
            return value switch
            {
                UploadProjectAvatarResponseEnvItemTarget.Development => "development",
                UploadProjectAvatarResponseEnvItemTarget.Preview => "preview",
                UploadProjectAvatarResponseEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => UploadProjectAvatarResponseEnvItemTarget.Development,
                "preview" => UploadProjectAvatarResponseEnvItemTarget.Preview,
                "production" => UploadProjectAvatarResponseEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}