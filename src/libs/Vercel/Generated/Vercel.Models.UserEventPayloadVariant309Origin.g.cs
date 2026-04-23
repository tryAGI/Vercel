
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant309Origin
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
    public static class UserEventPayloadVariant309OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant309Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant309Origin.App => "app",
                UserEventPayloadVariant309Origin.Apple => "apple",
                UserEventPayloadVariant309Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant309Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant309Origin.Email => "email",
                UserEventPayloadVariant309Origin.Emu => "emu",
                UserEventPayloadVariant309Origin.Github => "github",
                UserEventPayloadVariant309Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant309Origin.Gitlab => "gitlab",
                UserEventPayloadVariant309Origin.Google => "google",
                UserEventPayloadVariant309Origin.Invite => "invite",
                UserEventPayloadVariant309Origin.Manual => "manual",
                UserEventPayloadVariant309Origin.Otp => "otp",
                UserEventPayloadVariant309Origin.Passkey => "passkey",
                UserEventPayloadVariant309Origin.Saml => "saml",
                UserEventPayloadVariant309Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant309Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant309Origin.App,
                "apple" => UserEventPayloadVariant309Origin.Apple,
                "bitbucket" => UserEventPayloadVariant309Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant309Origin.Chatgpt,
                "email" => UserEventPayloadVariant309Origin.Email,
                "emu" => UserEventPayloadVariant309Origin.Emu,
                "github" => UserEventPayloadVariant309Origin.Github,
                "github-webhook" => UserEventPayloadVariant309Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant309Origin.Gitlab,
                "google" => UserEventPayloadVariant309Origin.Google,
                "invite" => UserEventPayloadVariant309Origin.Invite,
                "manual" => UserEventPayloadVariant309Origin.Manual,
                "otp" => UserEventPayloadVariant309Origin.Otp,
                "passkey" => UserEventPayloadVariant309Origin.Passkey,
                "saml" => UserEventPayloadVariant309Origin.Saml,
                "sms" => UserEventPayloadVariant309Origin.Sms,
                _ => null,
            };
        }
    }
}