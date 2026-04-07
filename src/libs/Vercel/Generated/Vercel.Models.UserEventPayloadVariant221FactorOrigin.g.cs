
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant221FactorOrigin
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
    public static class UserEventPayloadVariant221FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant221FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant221FactorOrigin.Apple => "apple",
                UserEventPayloadVariant221FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant221FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant221FactorOrigin.Email => "email",
                UserEventPayloadVariant221FactorOrigin.Github => "github",
                UserEventPayloadVariant221FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant221FactorOrigin.Google => "google",
                UserEventPayloadVariant221FactorOrigin.Otp => "otp",
                UserEventPayloadVariant221FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant221FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant221FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant221FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant221FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant221FactorOrigin.Email,
                "github" => UserEventPayloadVariant221FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant221FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant221FactorOrigin.Google,
                "otp" => UserEventPayloadVariant221FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant221FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}