
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant130FactorsVariant1ItemOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Apple,
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Chatgpt,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Invite,
        /// <summary>
        /// 
        /// </summary>
        MagicLink,
        /// <summary>
        /// 
        /// </summary>
        Otp,
        /// <summary>
        /// 
        /// </summary>
        OtpLink,
        /// <summary>
        /// 
        /// </summary>
        Saml,
        /// <summary>
        /// 
        /// </summary>
        Webauthn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant130FactorsVariant1ItemOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant130FactorsVariant1ItemOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Apple => "apple",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Email => "email",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Github => "github",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Google => "google",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Invite => "invite",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.MagicLink => "magic-link",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Otp => "otp",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.OtpLink => "otp-link",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Saml => "saml",
                UserEventPayloadVariant130FactorsVariant1ItemOrigin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant130FactorsVariant1ItemOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Chatgpt,
                "email" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Email,
                "github" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Github,
                "gitlab" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Gitlab,
                "google" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Google,
                "invite" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Invite,
                "magic-link" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.MagicLink,
                "otp" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Otp,
                "otp-link" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.OtpLink,
                "saml" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Saml,
                "webauthn" => UserEventPayloadVariant130FactorsVariant1ItemOrigin.Webauthn,
                _ => null,
            };
        }
    }
}