
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin
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
    public static class UserEventPayloadVariant124FactorsVariant2ItemVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Apple => "apple",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Email => "email",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Github => "github",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Gitlab => "gitlab",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Google => "google",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Invite => "invite",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.MagicLink => "magic-link",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Otp => "otp",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.OtpLink => "otp-link",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Saml => "saml",
                UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Apple,
                "bitbucket" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Chatgpt,
                "email" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Email,
                "github" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Github,
                "gitlab" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Gitlab,
                "google" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Google,
                "invite" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Invite,
                "magic-link" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.MagicLink,
                "otp" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Otp,
                "otp-link" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.OtpLink,
                "saml" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Saml,
                "webauthn" => UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin.Webauthn,
                _ => null,
            };
        }
    }
}