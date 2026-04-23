
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant235FactorOrigin
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
    public static class UserEventPayloadVariant235FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant235FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant235FactorOrigin.Apple => "apple",
                UserEventPayloadVariant235FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant235FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant235FactorOrigin.Email => "email",
                UserEventPayloadVariant235FactorOrigin.Github => "github",
                UserEventPayloadVariant235FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant235FactorOrigin.Google => "google",
                UserEventPayloadVariant235FactorOrigin.Otp => "otp",
                UserEventPayloadVariant235FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant235FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant235FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant235FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant235FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant235FactorOrigin.Email,
                "github" => UserEventPayloadVariant235FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant235FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant235FactorOrigin.Google,
                "otp" => UserEventPayloadVariant235FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant235FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}