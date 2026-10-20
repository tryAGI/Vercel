
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider
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
    public static class AutoSDKSharede3c00aaf9d3a15beSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider.Bitbucket => "bitbucket",
                AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider.Github => "github",
                AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider.Bitbucket,
                "github" => AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider.Github,
                "gitlab" => AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}