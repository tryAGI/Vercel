
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant309AuthMethod
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
    public static class UserEventPayloadVariant309AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant309AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant309AuthMethod.App => "app",
                UserEventPayloadVariant309AuthMethod.Apple => "apple",
                UserEventPayloadVariant309AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant309AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant309AuthMethod.Email => "email",
                UserEventPayloadVariant309AuthMethod.Emu => "emu",
                UserEventPayloadVariant309AuthMethod.Github => "github",
                UserEventPayloadVariant309AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant309AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant309AuthMethod.Google => "google",
                UserEventPayloadVariant309AuthMethod.Invite => "invite",
                UserEventPayloadVariant309AuthMethod.Manual => "manual",
                UserEventPayloadVariant309AuthMethod.Otp => "otp",
                UserEventPayloadVariant309AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant309AuthMethod.Saml => "saml",
                UserEventPayloadVariant309AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant309AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant309AuthMethod.App,
                "apple" => UserEventPayloadVariant309AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant309AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant309AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant309AuthMethod.Email,
                "emu" => UserEventPayloadVariant309AuthMethod.Emu,
                "github" => UserEventPayloadVariant309AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant309AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant309AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant309AuthMethod.Google,
                "invite" => UserEventPayloadVariant309AuthMethod.Invite,
                "manual" => UserEventPayloadVariant309AuthMethod.Manual,
                "otp" => UserEventPayloadVariant309AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant309AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant309AuthMethod.Saml,
                "sms" => UserEventPayloadVariant309AuthMethod.Sms,
                _ => null,
            };
        }
    }
}