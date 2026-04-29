
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin
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
    public static class UserEventPayloadVariant132FactorsVariant2ItemVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Apple => "apple",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Email => "email",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Github => "github",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Gitlab => "gitlab",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Google => "google",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Invite => "invite",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.MagicLink => "magic-link",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Otp => "otp",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.OtpLink => "otp-link",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Saml => "saml",
                UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Apple,
                "bitbucket" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Chatgpt,
                "email" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Email,
                "github" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Github,
                "gitlab" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Gitlab,
                "google" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Google,
                "invite" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Invite,
                "magic-link" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.MagicLink,
                "otp" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Otp,
                "otp-link" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.OtpLink,
                "saml" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Saml,
                "webauthn" => UserEventPayloadVariant132FactorsVariant2ItemVariant1Origin.Webauthn,
                _ => null,
            };
        }
    }
}