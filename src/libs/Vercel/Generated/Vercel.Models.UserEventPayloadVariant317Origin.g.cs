
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant317Origin
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
    public static class UserEventPayloadVariant317OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant317Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant317Origin.App => "app",
                UserEventPayloadVariant317Origin.Apple => "apple",
                UserEventPayloadVariant317Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant317Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant317Origin.Email => "email",
                UserEventPayloadVariant317Origin.Emu => "emu",
                UserEventPayloadVariant317Origin.Github => "github",
                UserEventPayloadVariant317Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant317Origin.Gitlab => "gitlab",
                UserEventPayloadVariant317Origin.Google => "google",
                UserEventPayloadVariant317Origin.Invite => "invite",
                UserEventPayloadVariant317Origin.Manual => "manual",
                UserEventPayloadVariant317Origin.Otp => "otp",
                UserEventPayloadVariant317Origin.Passkey => "passkey",
                UserEventPayloadVariant317Origin.Saml => "saml",
                UserEventPayloadVariant317Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant317Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant317Origin.App,
                "apple" => UserEventPayloadVariant317Origin.Apple,
                "bitbucket" => UserEventPayloadVariant317Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant317Origin.Chatgpt,
                "email" => UserEventPayloadVariant317Origin.Email,
                "emu" => UserEventPayloadVariant317Origin.Emu,
                "github" => UserEventPayloadVariant317Origin.Github,
                "github-webhook" => UserEventPayloadVariant317Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant317Origin.Gitlab,
                "google" => UserEventPayloadVariant317Origin.Google,
                "invite" => UserEventPayloadVariant317Origin.Invite,
                "manual" => UserEventPayloadVariant317Origin.Manual,
                "otp" => UserEventPayloadVariant317Origin.Otp,
                "passkey" => UserEventPayloadVariant317Origin.Passkey,
                "saml" => UserEventPayloadVariant317Origin.Saml,
                "sms" => UserEventPayloadVariant317Origin.Sms,
                _ => null,
            };
        }
    }
}