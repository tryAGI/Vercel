
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant321Origin
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
    public static class UserEventPayloadVariant321OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant321Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant321Origin.App => "app",
                UserEventPayloadVariant321Origin.Apple => "apple",
                UserEventPayloadVariant321Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant321Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant321Origin.Email => "email",
                UserEventPayloadVariant321Origin.Emu => "emu",
                UserEventPayloadVariant321Origin.Github => "github",
                UserEventPayloadVariant321Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant321Origin.Gitlab => "gitlab",
                UserEventPayloadVariant321Origin.Google => "google",
                UserEventPayloadVariant321Origin.Invite => "invite",
                UserEventPayloadVariant321Origin.Manual => "manual",
                UserEventPayloadVariant321Origin.Otp => "otp",
                UserEventPayloadVariant321Origin.Passkey => "passkey",
                UserEventPayloadVariant321Origin.Saml => "saml",
                UserEventPayloadVariant321Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant321Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant321Origin.App,
                "apple" => UserEventPayloadVariant321Origin.Apple,
                "bitbucket" => UserEventPayloadVariant321Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant321Origin.Chatgpt,
                "email" => UserEventPayloadVariant321Origin.Email,
                "emu" => UserEventPayloadVariant321Origin.Emu,
                "github" => UserEventPayloadVariant321Origin.Github,
                "github-webhook" => UserEventPayloadVariant321Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant321Origin.Gitlab,
                "google" => UserEventPayloadVariant321Origin.Google,
                "invite" => UserEventPayloadVariant321Origin.Invite,
                "manual" => UserEventPayloadVariant321Origin.Manual,
                "otp" => UserEventPayloadVariant321Origin.Otp,
                "passkey" => UserEventPayloadVariant321Origin.Passkey,
                "saml" => UserEventPayloadVariant321Origin.Saml,
                "sms" => UserEventPayloadVariant321Origin.Sms,
                _ => null,
            };
        }
    }
}