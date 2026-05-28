
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseEnvItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Encrypted,
        /// <summary>
        /// 
        /// </summary>
        Plain,
        /// <summary>
        /// 
        /// </summary>
        Secret,
        /// <summary>
        /// 
        /// </summary>
        Sensitive,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseEnvItemType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseEnvItemType.Encrypted => "encrypted",
                UploadProjectAvatarResponseEnvItemType.Plain => "plain",
                UploadProjectAvatarResponseEnvItemType.Secret => "secret",
                UploadProjectAvatarResponseEnvItemType.Sensitive => "sensitive",
                UploadProjectAvatarResponseEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UploadProjectAvatarResponseEnvItemType.Encrypted,
                "plain" => UploadProjectAvatarResponseEnvItemType.Plain,
                "secret" => UploadProjectAvatarResponseEnvItemType.Secret,
                "sensitive" => UploadProjectAvatarResponseEnvItemType.Sensitive,
                "system" => UploadProjectAvatarResponseEnvItemType.System,
                _ => null,
            };
        }
    }
}