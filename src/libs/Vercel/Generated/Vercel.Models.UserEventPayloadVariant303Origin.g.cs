
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant303Origin
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
    public static class UserEventPayloadVariant303OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant303Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant303Origin.App => "app",
                UserEventPayloadVariant303Origin.Apple => "apple",
                UserEventPayloadVariant303Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant303Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant303Origin.Email => "email",
                UserEventPayloadVariant303Origin.Emu => "emu",
                UserEventPayloadVariant303Origin.Github => "github",
                UserEventPayloadVariant303Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant303Origin.Gitlab => "gitlab",
                UserEventPayloadVariant303Origin.Google => "google",
                UserEventPayloadVariant303Origin.Invite => "invite",
                UserEventPayloadVariant303Origin.Manual => "manual",
                UserEventPayloadVariant303Origin.Otp => "otp",
                UserEventPayloadVariant303Origin.Passkey => "passkey",
                UserEventPayloadVariant303Origin.Saml => "saml",
                UserEventPayloadVariant303Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant303Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant303Origin.App,
                "apple" => UserEventPayloadVariant303Origin.Apple,
                "bitbucket" => UserEventPayloadVariant303Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant303Origin.Chatgpt,
                "email" => UserEventPayloadVariant303Origin.Email,
                "emu" => UserEventPayloadVariant303Origin.Emu,
                "github" => UserEventPayloadVariant303Origin.Github,
                "github-webhook" => UserEventPayloadVariant303Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant303Origin.Gitlab,
                "google" => UserEventPayloadVariant303Origin.Google,
                "invite" => UserEventPayloadVariant303Origin.Invite,
                "manual" => UserEventPayloadVariant303Origin.Manual,
                "otp" => UserEventPayloadVariant303Origin.Otp,
                "passkey" => UserEventPayloadVariant303Origin.Passkey,
                "saml" => UserEventPayloadVariant303Origin.Saml,
                "sms" => UserEventPayloadVariant303Origin.Sms,
                _ => null,
            };
        }
    }
}