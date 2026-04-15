
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant295AuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        App,
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
        Emu,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        GithubWebhook,
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
        Invite,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Otp,
        /// <summary>
        /// 
        /// </summary>
        Passkey,
        /// <summary>
        /// 
        /// </summary>
        Saml,
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant295AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant295AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant295AuthMethod.App => "app",
                UserEventPayloadVariant295AuthMethod.Apple => "apple",
                UserEventPayloadVariant295AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant295AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant295AuthMethod.Email => "email",
                UserEventPayloadVariant295AuthMethod.Emu => "emu",
                UserEventPayloadVariant295AuthMethod.Github => "github",
                UserEventPayloadVariant295AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant295AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant295AuthMethod.Google => "google",
                UserEventPayloadVariant295AuthMethod.Invite => "invite",
                UserEventPayloadVariant295AuthMethod.Manual => "manual",
                UserEventPayloadVariant295AuthMethod.Otp => "otp",
                UserEventPayloadVariant295AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant295AuthMethod.Saml => "saml",
                UserEventPayloadVariant295AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant295AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant295AuthMethod.App,
                "apple" => UserEventPayloadVariant295AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant295AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant295AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant295AuthMethod.Email,
                "emu" => UserEventPayloadVariant295AuthMethod.Emu,
                "github" => UserEventPayloadVariant295AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant295AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant295AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant295AuthMethod.Google,
                "invite" => UserEventPayloadVariant295AuthMethod.Invite,
                "manual" => UserEventPayloadVariant295AuthMethod.Manual,
                "otp" => UserEventPayloadVariant295AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant295AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant295AuthMethod.Saml,
                "sms" => UserEventPayloadVariant295AuthMethod.Sms,
                _ => null,
            };
        }
    }
}