
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant319Origin
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
    public static class UserEventPayloadVariant319OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant319Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant319Origin.App => "app",
                UserEventPayloadVariant319Origin.Apple => "apple",
                UserEventPayloadVariant319Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant319Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant319Origin.Email => "email",
                UserEventPayloadVariant319Origin.Emu => "emu",
                UserEventPayloadVariant319Origin.Github => "github",
                UserEventPayloadVariant319Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant319Origin.Gitlab => "gitlab",
                UserEventPayloadVariant319Origin.Google => "google",
                UserEventPayloadVariant319Origin.Invite => "invite",
                UserEventPayloadVariant319Origin.Manual => "manual",
                UserEventPayloadVariant319Origin.Otp => "otp",
                UserEventPayloadVariant319Origin.Passkey => "passkey",
                UserEventPayloadVariant319Origin.Saml => "saml",
                UserEventPayloadVariant319Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant319Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant319Origin.App,
                "apple" => UserEventPayloadVariant319Origin.Apple,
                "bitbucket" => UserEventPayloadVariant319Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant319Origin.Chatgpt,
                "email" => UserEventPayloadVariant319Origin.Email,
                "emu" => UserEventPayloadVariant319Origin.Emu,
                "github" => UserEventPayloadVariant319Origin.Github,
                "github-webhook" => UserEventPayloadVariant319Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant319Origin.Gitlab,
                "google" => UserEventPayloadVariant319Origin.Google,
                "invite" => UserEventPayloadVariant319Origin.Invite,
                "manual" => UserEventPayloadVariant319Origin.Manual,
                "otp" => UserEventPayloadVariant319Origin.Otp,
                "passkey" => UserEventPayloadVariant319Origin.Passkey,
                "saml" => UserEventPayloadVariant319Origin.Saml,
                "sms" => UserEventPayloadVariant319Origin.Sms,
                _ => null,
            };
        }
    }
}