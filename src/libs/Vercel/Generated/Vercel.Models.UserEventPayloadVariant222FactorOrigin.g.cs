
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant222FactorOrigin
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
    public static class UserEventPayloadVariant222FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant222FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant222FactorOrigin.Apple => "apple",
                UserEventPayloadVariant222FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant222FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant222FactorOrigin.Email => "email",
                UserEventPayloadVariant222FactorOrigin.Github => "github",
                UserEventPayloadVariant222FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant222FactorOrigin.Google => "google",
                UserEventPayloadVariant222FactorOrigin.Otp => "otp",
                UserEventPayloadVariant222FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant222FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant222FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant222FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant222FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant222FactorOrigin.Email,
                "github" => UserEventPayloadVariant222FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant222FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant222FactorOrigin.Google,
                "otp" => UserEventPayloadVariant222FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant222FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}