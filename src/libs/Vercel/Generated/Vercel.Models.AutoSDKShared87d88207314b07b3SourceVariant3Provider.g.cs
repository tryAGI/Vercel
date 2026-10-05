
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d88207314b07b3SourceVariant3Provider
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
    public static class AutoSDKShared87d88207314b07b3SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d88207314b07b3SourceVariant3Provider value)
        {
            return value switch
            {
                AutoSDKShared87d88207314b07b3SourceVariant3Provider.Bitbucket => "bitbucket",
                AutoSDKShared87d88207314b07b3SourceVariant3Provider.Github => "github",
                AutoSDKShared87d88207314b07b3SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d88207314b07b3SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKShared87d88207314b07b3SourceVariant3Provider.Bitbucket,
                "github" => AutoSDKShared87d88207314b07b3SourceVariant3Provider.Github,
                "gitlab" => AutoSDKShared87d88207314b07b3SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}