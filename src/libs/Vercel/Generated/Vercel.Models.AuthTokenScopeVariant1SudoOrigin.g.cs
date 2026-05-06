
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Possible step-up auth origins
    /// </summary>
    public enum AuthTokenScopeVariant1SudoOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        EmailOtp,
        /// <summary>
        /// 
        /// </summary>
        Otp,
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
                AuthTokenScopeVariant1SudoOrigin.EmailOtp => "email-otp",
                AuthTokenScopeVariant1SudoOrigin.Otp => "otp",
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
                "email-otp" => AuthTokenScopeVariant1SudoOrigin.EmailOtp,
                "otp" => AuthTokenScopeVariant1SudoOrigin.Otp,
                "recovery-code" => AuthTokenScopeVariant1SudoOrigin.RecoveryCode,
                "totp" => AuthTokenScopeVariant1SudoOrigin.Totp,
                "webauthn" => AuthTokenScopeVariant1SudoOrigin.Webauthn,
                _ => null,
            };
        }
    }
}