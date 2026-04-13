
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant226FactorOrigin
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
    public static class UserEventPayloadVariant226FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant226FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant226FactorOrigin.Apple => "apple",
                UserEventPayloadVariant226FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant226FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant226FactorOrigin.Email => "email",
                UserEventPayloadVariant226FactorOrigin.Github => "github",
                UserEventPayloadVariant226FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant226FactorOrigin.Google => "google",
                UserEventPayloadVariant226FactorOrigin.Otp => "otp",
                UserEventPayloadVariant226FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant226FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant226FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant226FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant226FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant226FactorOrigin.Email,
                "github" => UserEventPayloadVariant226FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant226FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant226FactorOrigin.Google,
                "otp" => UserEventPayloadVariant226FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant226FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}