
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant318Origin
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
    public static class UserEventPayloadVariant318OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant318Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant318Origin.App => "app",
                UserEventPayloadVariant318Origin.Apple => "apple",
                UserEventPayloadVariant318Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant318Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant318Origin.Email => "email",
                UserEventPayloadVariant318Origin.Emu => "emu",
                UserEventPayloadVariant318Origin.Github => "github",
                UserEventPayloadVariant318Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant318Origin.Gitlab => "gitlab",
                UserEventPayloadVariant318Origin.Google => "google",
                UserEventPayloadVariant318Origin.Invite => "invite",
                UserEventPayloadVariant318Origin.Manual => "manual",
                UserEventPayloadVariant318Origin.Otp => "otp",
                UserEventPayloadVariant318Origin.Passkey => "passkey",
                UserEventPayloadVariant318Origin.Saml => "saml",
                UserEventPayloadVariant318Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant318Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant318Origin.App,
                "apple" => UserEventPayloadVariant318Origin.Apple,
                "bitbucket" => UserEventPayloadVariant318Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant318Origin.Chatgpt,
                "email" => UserEventPayloadVariant318Origin.Email,
                "emu" => UserEventPayloadVariant318Origin.Emu,
                "github" => UserEventPayloadVariant318Origin.Github,
                "github-webhook" => UserEventPayloadVariant318Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant318Origin.Gitlab,
                "google" => UserEventPayloadVariant318Origin.Google,
                "invite" => UserEventPayloadVariant318Origin.Invite,
                "manual" => UserEventPayloadVariant318Origin.Manual,
                "otp" => UserEventPayloadVariant318Origin.Otp,
                "passkey" => UserEventPayloadVariant318Origin.Passkey,
                "saml" => UserEventPayloadVariant318Origin.Saml,
                "sms" => UserEventPayloadVariant318Origin.Sms,
                _ => null,
            };
        }
    }
}