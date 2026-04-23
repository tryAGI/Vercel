
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant234FactorOrigin
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
    public static class UserEventPayloadVariant234FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant234FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant234FactorOrigin.Apple => "apple",
                UserEventPayloadVariant234FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant234FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant234FactorOrigin.Email => "email",
                UserEventPayloadVariant234FactorOrigin.Github => "github",
                UserEventPayloadVariant234FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant234FactorOrigin.Google => "google",
                UserEventPayloadVariant234FactorOrigin.Otp => "otp",
                UserEventPayloadVariant234FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant234FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant234FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant234FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant234FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant234FactorOrigin.Email,
                "github" => UserEventPayloadVariant234FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant234FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant234FactorOrigin.Google,
                "otp" => UserEventPayloadVariant234FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant234FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}