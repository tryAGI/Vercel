
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin
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
    public static class UserEventPayloadVariant123FactorsVariant2ItemVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Apple => "apple",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Email => "email",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Github => "github",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Gitlab => "gitlab",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Google => "google",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Invite => "invite",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.MagicLink => "magic-link",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Otp => "otp",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.OtpLink => "otp-link",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Saml => "saml",
                UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Apple,
                "bitbucket" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Chatgpt,
                "email" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Email,
                "github" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Github,
                "gitlab" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Gitlab,
                "google" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Google,
                "invite" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Invite,
                "magic-link" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.MagicLink,
                "otp" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Otp,
                "otp-link" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.OtpLink,
                "saml" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Saml,
                "webauthn" => UserEventPayloadVariant123FactorsVariant2ItemVariant1Origin.Webauthn,
                _ => null,
            };
        }
    }
}