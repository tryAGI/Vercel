
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant292AuthMethod
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
    public static class UserEventPayloadVariant292AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant292AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant292AuthMethod.App => "app",
                UserEventPayloadVariant292AuthMethod.Apple => "apple",
                UserEventPayloadVariant292AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant292AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant292AuthMethod.Email => "email",
                UserEventPayloadVariant292AuthMethod.Emu => "emu",
                UserEventPayloadVariant292AuthMethod.Github => "github",
                UserEventPayloadVariant292AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant292AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant292AuthMethod.Google => "google",
                UserEventPayloadVariant292AuthMethod.Invite => "invite",
                UserEventPayloadVariant292AuthMethod.Manual => "manual",
                UserEventPayloadVariant292AuthMethod.Otp => "otp",
                UserEventPayloadVariant292AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant292AuthMethod.Saml => "saml",
                UserEventPayloadVariant292AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant292AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant292AuthMethod.App,
                "apple" => UserEventPayloadVariant292AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant292AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant292AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant292AuthMethod.Email,
                "emu" => UserEventPayloadVariant292AuthMethod.Emu,
                "github" => UserEventPayloadVariant292AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant292AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant292AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant292AuthMethod.Google,
                "invite" => UserEventPayloadVariant292AuthMethod.Invite,
                "manual" => UserEventPayloadVariant292AuthMethod.Manual,
                "otp" => UserEventPayloadVariant292AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant292AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant292AuthMethod.Saml,
                "sms" => UserEventPayloadVariant292AuthMethod.Sms,
                _ => null,
            };
        }
    }
}