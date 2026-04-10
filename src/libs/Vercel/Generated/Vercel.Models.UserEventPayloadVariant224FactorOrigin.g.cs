
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant224FactorOrigin
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
        Otp,
        /// <summary>
        /// 
        /// </summary>
        Saml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant224FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant224FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant224FactorOrigin.Apple => "apple",
                UserEventPayloadVariant224FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant224FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant224FactorOrigin.Email => "email",
                UserEventPayloadVariant224FactorOrigin.Github => "github",
                UserEventPayloadVariant224FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant224FactorOrigin.Google => "google",
                UserEventPayloadVariant224FactorOrigin.Otp => "otp",
                UserEventPayloadVariant224FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant224FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant224FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant224FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant224FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant224FactorOrigin.Email,
                "github" => UserEventPayloadVariant224FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant224FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant224FactorOrigin.Google,
                "otp" => UserEventPayloadVariant224FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant224FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}