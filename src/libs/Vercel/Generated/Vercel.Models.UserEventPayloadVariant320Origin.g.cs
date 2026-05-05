
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant320Origin
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
    public static class UserEventPayloadVariant320OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant320Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant320Origin.App => "app",
                UserEventPayloadVariant320Origin.Apple => "apple",
                UserEventPayloadVariant320Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant320Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant320Origin.Email => "email",
                UserEventPayloadVariant320Origin.Emu => "emu",
                UserEventPayloadVariant320Origin.Github => "github",
                UserEventPayloadVariant320Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant320Origin.Gitlab => "gitlab",
                UserEventPayloadVariant320Origin.Google => "google",
                UserEventPayloadVariant320Origin.Invite => "invite",
                UserEventPayloadVariant320Origin.Manual => "manual",
                UserEventPayloadVariant320Origin.Otp => "otp",
                UserEventPayloadVariant320Origin.Passkey => "passkey",
                UserEventPayloadVariant320Origin.Saml => "saml",
                UserEventPayloadVariant320Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant320Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant320Origin.App,
                "apple" => UserEventPayloadVariant320Origin.Apple,
                "bitbucket" => UserEventPayloadVariant320Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant320Origin.Chatgpt,
                "email" => UserEventPayloadVariant320Origin.Email,
                "emu" => UserEventPayloadVariant320Origin.Emu,
                "github" => UserEventPayloadVariant320Origin.Github,
                "github-webhook" => UserEventPayloadVariant320Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant320Origin.Gitlab,
                "google" => UserEventPayloadVariant320Origin.Google,
                "invite" => UserEventPayloadVariant320Origin.Invite,
                "manual" => UserEventPayloadVariant320Origin.Manual,
                "otp" => UserEventPayloadVariant320Origin.Otp,
                "passkey" => UserEventPayloadVariant320Origin.Passkey,
                "saml" => UserEventPayloadVariant320Origin.Saml,
                "sms" => UserEventPayloadVariant320Origin.Sms,
                _ => null,
            };
        }
    }
}