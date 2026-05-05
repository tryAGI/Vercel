
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246FactorOrigin
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
    public static class UserEventPayloadVariant246FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant246FactorOrigin.Apple => "apple",
                UserEventPayloadVariant246FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant246FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant246FactorOrigin.Email => "email",
                UserEventPayloadVariant246FactorOrigin.Github => "github",
                UserEventPayloadVariant246FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant246FactorOrigin.Google => "google",
                UserEventPayloadVariant246FactorOrigin.Otp => "otp",
                UserEventPayloadVariant246FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant246FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant246FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant246FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant246FactorOrigin.Email,
                "github" => UserEventPayloadVariant246FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant246FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant246FactorOrigin.Google,
                "otp" => UserEventPayloadVariant246FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant246FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}