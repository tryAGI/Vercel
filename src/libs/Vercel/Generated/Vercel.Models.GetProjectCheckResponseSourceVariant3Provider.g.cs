
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectCheckResponseSourceVariant3Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectCheckResponseSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectCheckResponseSourceVariant3Provider value)
        {
            return value switch
            {
                GetProjectCheckResponseSourceVariant3Provider.Bitbucket => "bitbucket",
                GetProjectCheckResponseSourceVariant3Provider.Github => "github",
                GetProjectCheckResponseSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectCheckResponseSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetProjectCheckResponseSourceVariant3Provider.Bitbucket,
                "github" => GetProjectCheckResponseSourceVariant3Provider.Github,
                "gitlab" => GetProjectCheckResponseSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}