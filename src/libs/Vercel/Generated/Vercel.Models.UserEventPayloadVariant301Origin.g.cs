
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant301Origin
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
    public static class UserEventPayloadVariant301OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant301Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant301Origin.App => "app",
                UserEventPayloadVariant301Origin.Apple => "apple",
                UserEventPayloadVariant301Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant301Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant301Origin.Email => "email",
                UserEventPayloadVariant301Origin.Emu => "emu",
                UserEventPayloadVariant301Origin.Github => "github",
                UserEventPayloadVariant301Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant301Origin.Gitlab => "gitlab",
                UserEventPayloadVariant301Origin.Google => "google",
                UserEventPayloadVariant301Origin.Invite => "invite",
                UserEventPayloadVariant301Origin.Manual => "manual",
                UserEventPayloadVariant301Origin.Otp => "otp",
                UserEventPayloadVariant301Origin.Passkey => "passkey",
                UserEventPayloadVariant301Origin.Saml => "saml",
                UserEventPayloadVariant301Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant301Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant301Origin.App,
                "apple" => UserEventPayloadVariant301Origin.Apple,
                "bitbucket" => UserEventPayloadVariant301Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant301Origin.Chatgpt,
                "email" => UserEventPayloadVariant301Origin.Email,
                "emu" => UserEventPayloadVariant301Origin.Emu,
                "github" => UserEventPayloadVariant301Origin.Github,
                "github-webhook" => UserEventPayloadVariant301Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant301Origin.Gitlab,
                "google" => UserEventPayloadVariant301Origin.Google,
                "invite" => UserEventPayloadVariant301Origin.Invite,
                "manual" => UserEventPayloadVariant301Origin.Manual,
                "otp" => UserEventPayloadVariant301Origin.Otp,
                "passkey" => UserEventPayloadVariant301Origin.Passkey,
                "saml" => UserEventPayloadVariant301Origin.Saml,
                "sms" => UserEventPayloadVariant301Origin.Sms,
                _ => null,
            };
        }
    }
}