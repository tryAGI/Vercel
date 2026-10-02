
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5455d199d07ea329SourceVariant3Provider
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
    public static class AutoSDKShared5455d199d07ea329SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5455d199d07ea329SourceVariant3Provider value)
        {
            return value switch
            {
                AutoSDKShared5455d199d07ea329SourceVariant3Provider.Bitbucket => "bitbucket",
                AutoSDKShared5455d199d07ea329SourceVariant3Provider.Github => "github",
                AutoSDKShared5455d199d07ea329SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5455d199d07ea329SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKShared5455d199d07ea329SourceVariant3Provider.Bitbucket,
                "github" => AutoSDKShared5455d199d07ea329SourceVariant3Provider.Github,
                "gitlab" => AutoSDKShared5455d199d07ea329SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}