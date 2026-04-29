
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant315AuthMethod
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
    public static class UserEventPayloadVariant315AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant315AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant315AuthMethod.App => "app",
                UserEventPayloadVariant315AuthMethod.Apple => "apple",
                UserEventPayloadVariant315AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant315AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant315AuthMethod.Email => "email",
                UserEventPayloadVariant315AuthMethod.Emu => "emu",
                UserEventPayloadVariant315AuthMethod.Github => "github",
                UserEventPayloadVariant315AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant315AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant315AuthMethod.Google => "google",
                UserEventPayloadVariant315AuthMethod.Invite => "invite",
                UserEventPayloadVariant315AuthMethod.Manual => "manual",
                UserEventPayloadVariant315AuthMethod.Otp => "otp",
                UserEventPayloadVariant315AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant315AuthMethod.Saml => "saml",
                UserEventPayloadVariant315AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant315AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant315AuthMethod.App,
                "apple" => UserEventPayloadVariant315AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant315AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant315AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant315AuthMethod.Email,
                "emu" => UserEventPayloadVariant315AuthMethod.Emu,
                "github" => UserEventPayloadVariant315AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant315AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant315AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant315AuthMethod.Google,
                "invite" => UserEventPayloadVariant315AuthMethod.Invite,
                "manual" => UserEventPayloadVariant315AuthMethod.Manual,
                "otp" => UserEventPayloadVariant315AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant315AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant315AuthMethod.Saml,
                "sms" => UserEventPayloadVariant315AuthMethod.Sms,
                _ => null,
            };
        }
    }
}