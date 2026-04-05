
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant220FactorOrigin
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
    public static class UserEventPayloadVariant220FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant220FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant220FactorOrigin.Apple => "apple",
                UserEventPayloadVariant220FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant220FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant220FactorOrigin.Email => "email",
                UserEventPayloadVariant220FactorOrigin.Github => "github",
                UserEventPayloadVariant220FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant220FactorOrigin.Google => "google",
                UserEventPayloadVariant220FactorOrigin.Otp => "otp",
                UserEventPayloadVariant220FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant220FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant220FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant220FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant220FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant220FactorOrigin.Email,
                "github" => UserEventPayloadVariant220FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant220FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant220FactorOrigin.Google,
                "otp" => UserEventPayloadVariant220FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant220FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}