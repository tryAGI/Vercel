
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant132FactorsVariant1ItemOrigin
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
    public static class UserEventPayloadVariant132FactorsVariant1ItemOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant132FactorsVariant1ItemOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Apple => "apple",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Email => "email",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Github => "github",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Google => "google",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Invite => "invite",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.MagicLink => "magic-link",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Otp => "otp",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.OtpLink => "otp-link",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Saml => "saml",
                UserEventPayloadVariant132FactorsVariant1ItemOrigin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant132FactorsVariant1ItemOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Chatgpt,
                "email" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Email,
                "github" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Github,
                "gitlab" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Gitlab,
                "google" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Google,
                "invite" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Invite,
                "magic-link" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.MagicLink,
                "otp" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Otp,
                "otp-link" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.OtpLink,
                "saml" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Saml,
                "webauthn" => UserEventPayloadVariant132FactorsVariant1ItemOrigin.Webauthn,
                _ => null,
            };
        }
    }
}