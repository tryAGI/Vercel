
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedceccd47983fcf9deVariant12GitProvider
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
    public static class AutoSDKSharedceccd47983fcf9deVariant12GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedceccd47983fcf9deVariant12GitProvider value)
        {
            return value switch
            {
                AutoSDKSharedceccd47983fcf9deVariant12GitProvider.Bitbucket => "bitbucket",
                AutoSDKSharedceccd47983fcf9deVariant12GitProvider.Github => "github",
                AutoSDKSharedceccd47983fcf9deVariant12GitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedceccd47983fcf9deVariant12GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKSharedceccd47983fcf9deVariant12GitProvider.Bitbucket,
                "github" => AutoSDKSharedceccd47983fcf9deVariant12GitProvider.Github,
                "gitlab" => AutoSDKSharedceccd47983fcf9deVariant12GitProvider.Gitlab,
                _ => null,
            };
        }
    }
}