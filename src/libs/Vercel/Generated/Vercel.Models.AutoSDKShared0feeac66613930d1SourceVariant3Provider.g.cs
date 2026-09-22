
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0feeac66613930d1SourceVariant3Provider
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
    public static class AutoSDKShared0feeac66613930d1SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0feeac66613930d1SourceVariant3Provider value)
        {
            return value switch
            {
                AutoSDKShared0feeac66613930d1SourceVariant3Provider.Bitbucket => "bitbucket",
                AutoSDKShared0feeac66613930d1SourceVariant3Provider.Github => "github",
                AutoSDKShared0feeac66613930d1SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0feeac66613930d1SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKShared0feeac66613930d1SourceVariant3Provider.Bitbucket,
                "github" => AutoSDKShared0feeac66613930d1SourceVariant3Provider.Github,
                "gitlab" => AutoSDKShared0feeac66613930d1SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}