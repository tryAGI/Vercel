
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant231FactorOrigin
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
    public static class UserEventPayloadVariant231FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant231FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant231FactorOrigin.Apple => "apple",
                UserEventPayloadVariant231FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant231FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant231FactorOrigin.Email => "email",
                UserEventPayloadVariant231FactorOrigin.Github => "github",
                UserEventPayloadVariant231FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant231FactorOrigin.Google => "google",
                UserEventPayloadVariant231FactorOrigin.Otp => "otp",
                UserEventPayloadVariant231FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant231FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant231FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant231FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant231FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant231FactorOrigin.Email,
                "github" => UserEventPayloadVariant231FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant231FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant231FactorOrigin.Google,
                "otp" => UserEventPayloadVariant231FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant231FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}