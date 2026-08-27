
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseEnvItemTargetItem
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
    public static class UploadProjectAvatarResponseEnvItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseEnvItemTargetItem value)
        {
            return value switch
            {
                UploadProjectAvatarResponseEnvItemTargetItem.Development => "development",
                UploadProjectAvatarResponseEnvItemTargetItem.Preview => "preview",
                UploadProjectAvatarResponseEnvItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseEnvItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UploadProjectAvatarResponseEnvItemTargetItem.Development,
                "preview" => UploadProjectAvatarResponseEnvItemTargetItem.Preview,
                "production" => UploadProjectAvatarResponseEnvItemTargetItem.Production,
                _ => null,
            };
        }
    }
}