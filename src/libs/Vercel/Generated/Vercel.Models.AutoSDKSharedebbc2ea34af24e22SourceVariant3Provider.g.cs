
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider
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
    public static class AutoSDKSharedebbc2ea34af24e22SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider.Bitbucket => "bitbucket",
                AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider.Github => "github",
                AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider.Bitbucket,
                "github" => AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider.Github,
                "gitlab" => AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}