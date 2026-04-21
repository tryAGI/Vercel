
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant303AuthMethod
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
    public static class UserEventPayloadVariant303AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant303AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant303AuthMethod.App => "app",
                UserEventPayloadVariant303AuthMethod.Apple => "apple",
                UserEventPayloadVariant303AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant303AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant303AuthMethod.Email => "email",
                UserEventPayloadVariant303AuthMethod.Emu => "emu",
                UserEventPayloadVariant303AuthMethod.Github => "github",
                UserEventPayloadVariant303AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant303AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant303AuthMethod.Google => "google",
                UserEventPayloadVariant303AuthMethod.Invite => "invite",
                UserEventPayloadVariant303AuthMethod.Manual => "manual",
                UserEventPayloadVariant303AuthMethod.Otp => "otp",
                UserEventPayloadVariant303AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant303AuthMethod.Saml => "saml",
                UserEventPayloadVariant303AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant303AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant303AuthMethod.App,
                "apple" => UserEventPayloadVariant303AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant303AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant303AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant303AuthMethod.Email,
                "emu" => UserEventPayloadVariant303AuthMethod.Emu,
                "github" => UserEventPayloadVariant303AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant303AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant303AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant303AuthMethod.Google,
                "invite" => UserEventPayloadVariant303AuthMethod.Invite,
                "manual" => UserEventPayloadVariant303AuthMethod.Manual,
                "otp" => UserEventPayloadVariant303AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant303AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant303AuthMethod.Saml,
                "sms" => UserEventPayloadVariant303AuthMethod.Sms,
                _ => null,
            };
        }
    }
}