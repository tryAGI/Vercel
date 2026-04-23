
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant306Origin
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
    public static class UserEventPayloadVariant306OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant306Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant306Origin.App => "app",
                UserEventPayloadVariant306Origin.Apple => "apple",
                UserEventPayloadVariant306Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant306Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant306Origin.Email => "email",
                UserEventPayloadVariant306Origin.Emu => "emu",
                UserEventPayloadVariant306Origin.Github => "github",
                UserEventPayloadVariant306Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant306Origin.Gitlab => "gitlab",
                UserEventPayloadVariant306Origin.Google => "google",
                UserEventPayloadVariant306Origin.Invite => "invite",
                UserEventPayloadVariant306Origin.Manual => "manual",
                UserEventPayloadVariant306Origin.Otp => "otp",
                UserEventPayloadVariant306Origin.Passkey => "passkey",
                UserEventPayloadVariant306Origin.Saml => "saml",
                UserEventPayloadVariant306Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant306Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant306Origin.App,
                "apple" => UserEventPayloadVariant306Origin.Apple,
                "bitbucket" => UserEventPayloadVariant306Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant306Origin.Chatgpt,
                "email" => UserEventPayloadVariant306Origin.Email,
                "emu" => UserEventPayloadVariant306Origin.Emu,
                "github" => UserEventPayloadVariant306Origin.Github,
                "github-webhook" => UserEventPayloadVariant306Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant306Origin.Gitlab,
                "google" => UserEventPayloadVariant306Origin.Google,
                "invite" => UserEventPayloadVariant306Origin.Invite,
                "manual" => UserEventPayloadVariant306Origin.Manual,
                "otp" => UserEventPayloadVariant306Origin.Otp,
                "passkey" => UserEventPayloadVariant306Origin.Passkey,
                "saml" => UserEventPayloadVariant306Origin.Saml,
                "sms" => UserEventPayloadVariant306Origin.Sms,
                _ => null,
            };
        }
    }
}