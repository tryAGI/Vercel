
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant307AuthMethod
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
    public static class UserEventPayloadVariant307AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant307AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant307AuthMethod.App => "app",
                UserEventPayloadVariant307AuthMethod.Apple => "apple",
                UserEventPayloadVariant307AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant307AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant307AuthMethod.Email => "email",
                UserEventPayloadVariant307AuthMethod.Emu => "emu",
                UserEventPayloadVariant307AuthMethod.Github => "github",
                UserEventPayloadVariant307AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant307AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant307AuthMethod.Google => "google",
                UserEventPayloadVariant307AuthMethod.Invite => "invite",
                UserEventPayloadVariant307AuthMethod.Manual => "manual",
                UserEventPayloadVariant307AuthMethod.Otp => "otp",
                UserEventPayloadVariant307AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant307AuthMethod.Saml => "saml",
                UserEventPayloadVariant307AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant307AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant307AuthMethod.App,
                "apple" => UserEventPayloadVariant307AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant307AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant307AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant307AuthMethod.Email,
                "emu" => UserEventPayloadVariant307AuthMethod.Emu,
                "github" => UserEventPayloadVariant307AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant307AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant307AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant307AuthMethod.Google,
                "invite" => UserEventPayloadVariant307AuthMethod.Invite,
                "manual" => UserEventPayloadVariant307AuthMethod.Manual,
                "otp" => UserEventPayloadVariant307AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant307AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant307AuthMethod.Saml,
                "sms" => UserEventPayloadVariant307AuthMethod.Sms,
                _ => null,
            };
        }
    }
}