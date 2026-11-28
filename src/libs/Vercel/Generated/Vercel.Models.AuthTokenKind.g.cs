
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The user-facing kind of the token.<br/>
    /// Example: access-token
    /// </summary>
    public enum AuthTokenKind
    {
        /// <summary>
        ///
        /// </summary>
        AccessToken,
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        SignInSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthTokenKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthTokenKind value)
        {
            return value switch
            {
                AuthTokenKind.AccessToken => "access-token",
                AuthTokenKind.App => "app",
                AuthTokenKind.Other => "other",
                AuthTokenKind.SignInSession => "sign-in-session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthTokenKind? ToEnum(string value)
        {
            return value switch
            {
                "access-token" => AuthTokenKind.AccessToken,
                "app" => AuthTokenKind.App,
                "other" => AuthTokenKind.Other,
                "sign-in-session" => AuthTokenKind.SignInSession,
                _ => null,
            };
        }
    }
}