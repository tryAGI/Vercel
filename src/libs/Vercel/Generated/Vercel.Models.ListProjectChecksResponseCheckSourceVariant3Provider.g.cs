
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectChecksResponseCheckSourceVariant3Provider
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
    public static class ListProjectChecksResponseCheckSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectChecksResponseCheckSourceVariant3Provider value)
        {
            return value switch
            {
                ListProjectChecksResponseCheckSourceVariant3Provider.Bitbucket => "bitbucket",
                ListProjectChecksResponseCheckSourceVariant3Provider.Github => "github",
                ListProjectChecksResponseCheckSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectChecksResponseCheckSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => ListProjectChecksResponseCheckSourceVariant3Provider.Bitbucket,
                "github" => ListProjectChecksResponseCheckSourceVariant3Provider.Github,
                "gitlab" => ListProjectChecksResponseCheckSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}