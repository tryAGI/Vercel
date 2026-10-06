
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9SourceVariant3Provider
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
    public static class AutoSDKShared12773eaec07789a9SourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9SourceVariant3Provider value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9SourceVariant3Provider.Bitbucket => "bitbucket",
                AutoSDKShared12773eaec07789a9SourceVariant3Provider.Github => "github",
                AutoSDKShared12773eaec07789a9SourceVariant3Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9SourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKShared12773eaec07789a9SourceVariant3Provider.Bitbucket,
                "github" => AutoSDKShared12773eaec07789a9SourceVariant3Provider.Github,
                "gitlab" => AutoSDKShared12773eaec07789a9SourceVariant3Provider.Gitlab,
                _ => null,
            };
        }
    }
}