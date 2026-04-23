
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the token was issued. Always `'manual'` for explicit PAT creation.
    /// </summary>
    public enum UserEventPayloadVariant308Origin
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
    public static class UserEventPayloadVariant308OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant308Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant308Origin.App => "app",
                UserEventPayloadVariant308Origin.Apple => "apple",
                UserEventPayloadVariant308Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant308Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant308Origin.Email => "email",
                UserEventPayloadVariant308Origin.Emu => "emu",
                UserEventPayloadVariant308Origin.Github => "github",
                UserEventPayloadVariant308Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant308Origin.Gitlab => "gitlab",
                UserEventPayloadVariant308Origin.Google => "google",
                UserEventPayloadVariant308Origin.Invite => "invite",
                UserEventPayloadVariant308Origin.Manual => "manual",
                UserEventPayloadVariant308Origin.Otp => "otp",
                UserEventPayloadVariant308Origin.Passkey => "passkey",
                UserEventPayloadVariant308Origin.Saml => "saml",
                UserEventPayloadVariant308Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant308Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant308Origin.App,
                "apple" => UserEventPayloadVariant308Origin.Apple,
                "bitbucket" => UserEventPayloadVariant308Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant308Origin.Chatgpt,
                "email" => UserEventPayloadVariant308Origin.Email,
                "emu" => UserEventPayloadVariant308Origin.Emu,
                "github" => UserEventPayloadVariant308Origin.Github,
                "github-webhook" => UserEventPayloadVariant308Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant308Origin.Gitlab,
                "google" => UserEventPayloadVariant308Origin.Google,
                "invite" => UserEventPayloadVariant308Origin.Invite,
                "manual" => UserEventPayloadVariant308Origin.Manual,
                "otp" => UserEventPayloadVariant308Origin.Otp,
                "passkey" => UserEventPayloadVariant308Origin.Passkey,
                "saml" => UserEventPayloadVariant308Origin.Saml,
                "sms" => UserEventPayloadVariant308Origin.Sms,
                _ => null,
            };
        }
    }
}