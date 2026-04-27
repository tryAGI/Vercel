
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant236FactorOrigin
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
    public static class UserEventPayloadVariant236FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant236FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant236FactorOrigin.Apple => "apple",
                UserEventPayloadVariant236FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant236FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant236FactorOrigin.Email => "email",
                UserEventPayloadVariant236FactorOrigin.Github => "github",
                UserEventPayloadVariant236FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant236FactorOrigin.Google => "google",
                UserEventPayloadVariant236FactorOrigin.Otp => "otp",
                UserEventPayloadVariant236FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant236FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant236FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant236FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant236FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant236FactorOrigin.Email,
                "github" => UserEventPayloadVariant236FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant236FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant236FactorOrigin.Google,
                "otp" => UserEventPayloadVariant236FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant236FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}