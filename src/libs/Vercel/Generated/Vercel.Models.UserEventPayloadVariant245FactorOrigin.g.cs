
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245FactorOrigin
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
    public static class UserEventPayloadVariant245FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant245FactorOrigin.Apple => "apple",
                UserEventPayloadVariant245FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant245FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant245FactorOrigin.Email => "email",
                UserEventPayloadVariant245FactorOrigin.Github => "github",
                UserEventPayloadVariant245FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant245FactorOrigin.Google => "google",
                UserEventPayloadVariant245FactorOrigin.Otp => "otp",
                UserEventPayloadVariant245FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant245FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant245FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant245FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant245FactorOrigin.Email,
                "github" => UserEventPayloadVariant245FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant245FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant245FactorOrigin.Google,
                "otp" => UserEventPayloadVariant245FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant245FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}