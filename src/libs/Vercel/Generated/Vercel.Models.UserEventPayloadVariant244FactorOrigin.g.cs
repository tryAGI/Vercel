
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244FactorOrigin
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
    public static class UserEventPayloadVariant244FactorOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244FactorOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant244FactorOrigin.Apple => "apple",
                UserEventPayloadVariant244FactorOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant244FactorOrigin.Chatgpt => "chatgpt",
                UserEventPayloadVariant244FactorOrigin.Email => "email",
                UserEventPayloadVariant244FactorOrigin.Github => "github",
                UserEventPayloadVariant244FactorOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant244FactorOrigin.Google => "google",
                UserEventPayloadVariant244FactorOrigin.Otp => "otp",
                UserEventPayloadVariant244FactorOrigin.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244FactorOrigin? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant244FactorOrigin.Apple,
                "bitbucket" => UserEventPayloadVariant244FactorOrigin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant244FactorOrigin.Chatgpt,
                "email" => UserEventPayloadVariant244FactorOrigin.Email,
                "github" => UserEventPayloadVariant244FactorOrigin.Github,
                "gitlab" => UserEventPayloadVariant244FactorOrigin.Gitlab,
                "google" => UserEventPayloadVariant244FactorOrigin.Google,
                "otp" => UserEventPayloadVariant244FactorOrigin.Otp,
                "saml" => UserEventPayloadVariant244FactorOrigin.Saml,
                _ => null,
            };
        }
    }
}