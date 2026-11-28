
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter by token kind. Omit or use `all` to include every kind.
    /// </summary>
    public enum ListAuthTokensKind
    {
        /// <summary>
        ///
        /// </summary>
        AccessToken,
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        SignInSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAuthTokensKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAuthTokensKind value)
        {
            return value switch
            {
                ListAuthTokensKind.AccessToken => "access-token",
                ListAuthTokensKind.All => "all",
                ListAuthTokensKind.App => "app",
                ListAuthTokensKind.SignInSession => "sign-in-session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAuthTokensKind? ToEnum(string value)
        {
            return value switch
            {
                "access-token" => ListAuthTokensKind.AccessToken,
                "all" => ListAuthTokensKind.All,
                "app" => ListAuthTokensKind.App,
                "sign-in-session" => ListAuthTokensKind.SignInSession,
                _ => null,
            };
        }
    }
}