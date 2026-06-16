
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseLinkVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseLinkVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLinkVariant3Type value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLinkVariant3Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLinkVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => UploadProjectAvatarResponseLinkVariant3Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}