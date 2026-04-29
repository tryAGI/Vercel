
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant316Origin
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
    public static class UserEventPayloadVariant316OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant316Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant316Origin.App => "app",
                UserEventPayloadVariant316Origin.Apple => "apple",
                UserEventPayloadVariant316Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant316Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant316Origin.Email => "email",
                UserEventPayloadVariant316Origin.Emu => "emu",
                UserEventPayloadVariant316Origin.Github => "github",
                UserEventPayloadVariant316Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant316Origin.Gitlab => "gitlab",
                UserEventPayloadVariant316Origin.Google => "google",
                UserEventPayloadVariant316Origin.Invite => "invite",
                UserEventPayloadVariant316Origin.Manual => "manual",
                UserEventPayloadVariant316Origin.Otp => "otp",
                UserEventPayloadVariant316Origin.Passkey => "passkey",
                UserEventPayloadVariant316Origin.Saml => "saml",
                UserEventPayloadVariant316Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant316Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant316Origin.App,
                "apple" => UserEventPayloadVariant316Origin.Apple,
                "bitbucket" => UserEventPayloadVariant316Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant316Origin.Chatgpt,
                "email" => UserEventPayloadVariant316Origin.Email,
                "emu" => UserEventPayloadVariant316Origin.Emu,
                "github" => UserEventPayloadVariant316Origin.Github,
                "github-webhook" => UserEventPayloadVariant316Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant316Origin.Gitlab,
                "google" => UserEventPayloadVariant316Origin.Google,
                "invite" => UserEventPayloadVariant316Origin.Invite,
                "manual" => UserEventPayloadVariant316Origin.Manual,
                "otp" => UserEventPayloadVariant316Origin.Otp,
                "passkey" => UserEventPayloadVariant316Origin.Passkey,
                "saml" => UserEventPayloadVariant316Origin.Saml,
                "sms" => UserEventPayloadVariant316Origin.Sms,
                _ => null,
            };
        }
    }
}