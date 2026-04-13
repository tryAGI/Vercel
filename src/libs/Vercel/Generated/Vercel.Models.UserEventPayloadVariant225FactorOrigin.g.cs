
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant225FactorOrigin
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
    public static class UserEventPayloadVariant225FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant225FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant225FactorOrigin.Apple => "apple",
                UserEventPayloadVariant225FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant225FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant225FactorOrigin.Email => "email",
                UserEventPayloadVariant225FactorOrigin.Github => "github",
                UserEventPayloadVariant225FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant225FactorOrigin.Google => "google",
                UserEventPayloadVariant225FactorOrigin.Otp => "otp",
                UserEventPayloadVariant225FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant225FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant225FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant225FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant225FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant225FactorOrigin.Email,
                "github" => UserEventPayloadVariant225FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant225FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant225FactorOrigin.Google,
                "otp" => UserEventPayloadVariant225FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant225FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}