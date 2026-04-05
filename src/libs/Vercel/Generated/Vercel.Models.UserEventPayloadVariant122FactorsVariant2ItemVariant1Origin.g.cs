
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin
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
    public static class UserEventPayloadVariant122FactorsVariant2ItemVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Apple => "apple",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Email => "email",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Github => "github",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Gitlab => "gitlab",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Google => "google",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Invite => "invite",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.MagicLink => "magic-link",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Otp => "otp",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.OtpLink => "otp-link",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Saml => "saml",
                UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Apple,
                "bitbucket" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Chatgpt,
                "email" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Email,
                "github" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Github,
                "gitlab" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Gitlab,
                "google" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Google,
                "invite" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Invite,
                "magic-link" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.MagicLink,
                "otp" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Otp,
                "otp-link" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.OtpLink,
                "saml" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Saml,
                "webauthn" => UserEventPayloadVariant122FactorsVariant2ItemVariant1Origin.Webauthn,
                _ => null,
            };
        }
    }
}