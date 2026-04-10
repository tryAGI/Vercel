
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant123FactorsVariant1ItemOrigin
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
    public static class UserEventPayloadVariant123FactorsVariant1ItemOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant123FactorsVariant1ItemOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Apple => "apple",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Email => "email",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Github => "github",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Google => "google",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Invite => "invite",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.MagicLink => "magic-link",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Otp => "otp",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.OtpLink => "otp-link",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Saml => "saml",
                UserEventPayloadVariant123FactorsVariant1ItemOrigin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant123FactorsVariant1ItemOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Chatgpt,
                "email" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Email,
                "github" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Github,
                "gitlab" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Gitlab,
                "google" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Google,
                "invite" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Invite,
                "magic-link" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.MagicLink,
                "otp" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Otp,
                "otp-link" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.OtpLink,
                "saml" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Saml,
                "webauthn" => UserEventPayloadVariant123FactorsVariant1ItemOrigin.Webauthn,
                _ => null,
            };
        }
    }
}