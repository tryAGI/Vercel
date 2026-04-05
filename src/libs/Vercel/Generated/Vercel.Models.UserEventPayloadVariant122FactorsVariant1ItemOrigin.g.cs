
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122FactorsVariant1ItemOrigin
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
    public static class UserEventPayloadVariant122FactorsVariant1ItemOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122FactorsVariant1ItemOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Apple => "apple",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Email => "email",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Github => "github",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Google => "google",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Invite => "invite",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.MagicLink => "magic-link",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Otp => "otp",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.OtpLink => "otp-link",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Saml => "saml",
                UserEventPayloadVariant122FactorsVariant1ItemOrigin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122FactorsVariant1ItemOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Chatgpt,
                "email" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Email,
                "github" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Github,
                "gitlab" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Gitlab,
                "google" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Google,
                "invite" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Invite,
                "magic-link" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.MagicLink,
                "otp" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Otp,
                "otp-link" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.OtpLink,
                "saml" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Saml,
                "webauthn" => UserEventPayloadVariant122FactorsVariant1ItemOrigin.Webauthn,
                _ => null,
            };
        }
    }
}