
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant310Origin
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
    public static class UserEventPayloadVariant310OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant310Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant310Origin.App => "app",
                UserEventPayloadVariant310Origin.Apple => "apple",
                UserEventPayloadVariant310Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant310Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant310Origin.Email => "email",
                UserEventPayloadVariant310Origin.Emu => "emu",
                UserEventPayloadVariant310Origin.Github => "github",
                UserEventPayloadVariant310Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant310Origin.Gitlab => "gitlab",
                UserEventPayloadVariant310Origin.Google => "google",
                UserEventPayloadVariant310Origin.Invite => "invite",
                UserEventPayloadVariant310Origin.Manual => "manual",
                UserEventPayloadVariant310Origin.Otp => "otp",
                UserEventPayloadVariant310Origin.Passkey => "passkey",
                UserEventPayloadVariant310Origin.Saml => "saml",
                UserEventPayloadVariant310Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant310Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant310Origin.App,
                "apple" => UserEventPayloadVariant310Origin.Apple,
                "bitbucket" => UserEventPayloadVariant310Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant310Origin.Chatgpt,
                "email" => UserEventPayloadVariant310Origin.Email,
                "emu" => UserEventPayloadVariant310Origin.Emu,
                "github" => UserEventPayloadVariant310Origin.Github,
                "github-webhook" => UserEventPayloadVariant310Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant310Origin.Gitlab,
                "google" => UserEventPayloadVariant310Origin.Google,
                "invite" => UserEventPayloadVariant310Origin.Invite,
                "manual" => UserEventPayloadVariant310Origin.Manual,
                "otp" => UserEventPayloadVariant310Origin.Otp,
                "passkey" => UserEventPayloadVariant310Origin.Passkey,
                "saml" => UserEventPayloadVariant310Origin.Saml,
                "sms" => UserEventPayloadVariant310Origin.Sms,
                _ => null,
            };
        }
    }
}