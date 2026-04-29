
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant242FactorOrigin
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
    public static class UserEventPayloadVariant242FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant242FactorOrigin.Apple => "apple",
                UserEventPayloadVariant242FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant242FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant242FactorOrigin.Email => "email",
                UserEventPayloadVariant242FactorOrigin.Github => "github",
                UserEventPayloadVariant242FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant242FactorOrigin.Google => "google",
                UserEventPayloadVariant242FactorOrigin.Otp => "otp",
                UserEventPayloadVariant242FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant242FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant242FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant242FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant242FactorOrigin.Email,
                "github" => UserEventPayloadVariant242FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant242FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant242FactorOrigin.Google,
                "otp" => UserEventPayloadVariant242FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant242FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}