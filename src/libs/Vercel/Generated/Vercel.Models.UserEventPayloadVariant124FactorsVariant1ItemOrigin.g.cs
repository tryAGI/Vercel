
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant124FactorsVariant1ItemOrigin
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
    public static class UserEventPayloadVariant124FactorsVariant1ItemOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant124FactorsVariant1ItemOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Apple => "apple",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Email => "email",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Github => "github",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Google => "google",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Invite => "invite",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.MagicLink => "magic-link",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Otp => "otp",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.OtpLink => "otp-link",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Saml => "saml",
                UserEventPayloadVariant124FactorsVariant1ItemOrigin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant124FactorsVariant1ItemOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Chatgpt,
                "email" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Email,
                "github" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Github,
                "gitlab" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Gitlab,
                "google" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Google,
                "invite" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Invite,
                "magic-link" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.MagicLink,
                "otp" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Otp,
                "otp-link" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.OtpLink,
                "saml" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Saml,
                "webauthn" => UserEventPayloadVariant124FactorsVariant1ItemOrigin.Webauthn,
                _ => null,
            };
        }
    }
}