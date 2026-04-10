
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant223FactorOrigin
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
    public static class UserEventPayloadVariant223FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant223FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant223FactorOrigin.Apple => "apple",
                UserEventPayloadVariant223FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant223FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant223FactorOrigin.Email => "email",
                UserEventPayloadVariant223FactorOrigin.Github => "github",
                UserEventPayloadVariant223FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant223FactorOrigin.Google => "google",
                UserEventPayloadVariant223FactorOrigin.Otp => "otp",
                UserEventPayloadVariant223FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant223FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant223FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant223FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant223FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant223FactorOrigin.Email,
                "github" => UserEventPayloadVariant223FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant223FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant223FactorOrigin.Google,
                "otp" => UserEventPayloadVariant223FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant223FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}