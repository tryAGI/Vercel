
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Possible multi-factor origins
    /// </summary>
    public enum AuthTokenScopeVariant1SudoOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        RecoveryCode,
        /// <summary>
        /// 
        /// </summary>
        Totp,
        /// <summary>
        /// 
        /// </summary>
        Webauthn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthTokenScopeVariant1SudoOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthTokenScopeVariant1SudoOrigin value)
        {
            return value switch
            {
                AuthTokenScopeVariant1SudoOrigin.RecoveryCode => "recovery-code",
                AuthTokenScopeVariant1SudoOrigin.Totp => "totp",
                AuthTokenScopeVariant1SudoOrigin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthTokenScopeVariant1SudoOrigin? ToEnum(string value)
        {
            return value switch
            {
                "recovery-code" => AuthTokenScopeVariant1SudoOrigin.RecoveryCode,
                "totp" => AuthTokenScopeVariant1SudoOrigin.Totp,
                "webauthn" => AuthTokenScopeVariant1SudoOrigin.Webauthn,
                _ => null,
            };
        }
    }
}