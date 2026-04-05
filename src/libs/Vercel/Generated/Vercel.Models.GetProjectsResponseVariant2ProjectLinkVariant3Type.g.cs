
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectLinkVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectLinkVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectLinkVariant3Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectLinkVariant3Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectLinkVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => GetProjectsResponseVariant2ProjectLinkVariant3Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}