
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant232FactorOrigin
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
    public static class UserEventPayloadVariant232FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant232FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant232FactorOrigin.Apple => "apple",
                UserEventPayloadVariant232FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant232FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant232FactorOrigin.Email => "email",
                UserEventPayloadVariant232FactorOrigin.Github => "github",
                UserEventPayloadVariant232FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant232FactorOrigin.Google => "google",
                UserEventPayloadVariant232FactorOrigin.Otp => "otp",
                UserEventPayloadVariant232FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant232FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant232FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant232FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant232FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant232FactorOrigin.Email,
                "github" => UserEventPayloadVariant232FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant232FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant232FactorOrigin.Google,
                "otp" => UserEventPayloadVariant232FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant232FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}