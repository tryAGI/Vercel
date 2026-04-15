
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant227FactorOrigin
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
    public static class UserEventPayloadVariant227FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant227FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant227FactorOrigin.Apple => "apple",
                UserEventPayloadVariant227FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant227FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant227FactorOrigin.Email => "email",
                UserEventPayloadVariant227FactorOrigin.Github => "github",
                UserEventPayloadVariant227FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant227FactorOrigin.Google => "google",
                UserEventPayloadVariant227FactorOrigin.Otp => "otp",
                UserEventPayloadVariant227FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant227FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant227FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant227FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant227FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant227FactorOrigin.Email,
                "github" => UserEventPayloadVariant227FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant227FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant227FactorOrigin.Google,
                "otp" => UserEventPayloadVariant227FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant227FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}