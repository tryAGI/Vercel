
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant304Origin
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
    public static class UserEventPayloadVariant304OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant304Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant304Origin.App => "app",
                UserEventPayloadVariant304Origin.Apple => "apple",
                UserEventPayloadVariant304Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant304Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant304Origin.Email => "email",
                UserEventPayloadVariant304Origin.Emu => "emu",
                UserEventPayloadVariant304Origin.Github => "github",
                UserEventPayloadVariant304Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant304Origin.Gitlab => "gitlab",
                UserEventPayloadVariant304Origin.Google => "google",
                UserEventPayloadVariant304Origin.Invite => "invite",
                UserEventPayloadVariant304Origin.Manual => "manual",
                UserEventPayloadVariant304Origin.Otp => "otp",
                UserEventPayloadVariant304Origin.Passkey => "passkey",
                UserEventPayloadVariant304Origin.Saml => "saml",
                UserEventPayloadVariant304Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant304Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant304Origin.App,
                "apple" => UserEventPayloadVariant304Origin.Apple,
                "bitbucket" => UserEventPayloadVariant304Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant304Origin.Chatgpt,
                "email" => UserEventPayloadVariant304Origin.Email,
                "emu" => UserEventPayloadVariant304Origin.Emu,
                "github" => UserEventPayloadVariant304Origin.Github,
                "github-webhook" => UserEventPayloadVariant304Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant304Origin.Gitlab,
                "google" => UserEventPayloadVariant304Origin.Google,
                "invite" => UserEventPayloadVariant304Origin.Invite,
                "manual" => UserEventPayloadVariant304Origin.Manual,
                "otp" => UserEventPayloadVariant304Origin.Otp,
                "passkey" => UserEventPayloadVariant304Origin.Passkey,
                "saml" => UserEventPayloadVariant304Origin.Saml,
                "sms" => UserEventPayloadVariant304Origin.Sms,
                _ => null,
            };
        }
    }
}