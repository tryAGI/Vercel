
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLinkVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseLinkVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLinkVariant3Type value)
        {
            return value switch
            {
                GetProjectResponseLinkVariant3Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLinkVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => GetProjectResponseLinkVariant3Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}