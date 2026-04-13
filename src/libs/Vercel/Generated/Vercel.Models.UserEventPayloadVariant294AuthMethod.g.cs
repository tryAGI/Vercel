
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant294AuthMethod
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
    public static class UserEventPayloadVariant294AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant294AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant294AuthMethod.App => "app",
                UserEventPayloadVariant294AuthMethod.Apple => "apple",
                UserEventPayloadVariant294AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant294AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant294AuthMethod.Email => "email",
                UserEventPayloadVariant294AuthMethod.Emu => "emu",
                UserEventPayloadVariant294AuthMethod.Github => "github",
                UserEventPayloadVariant294AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant294AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant294AuthMethod.Google => "google",
                UserEventPayloadVariant294AuthMethod.Invite => "invite",
                UserEventPayloadVariant294AuthMethod.Manual => "manual",
                UserEventPayloadVariant294AuthMethod.Otp => "otp",
                UserEventPayloadVariant294AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant294AuthMethod.Saml => "saml",
                UserEventPayloadVariant294AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant294AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant294AuthMethod.App,
                "apple" => UserEventPayloadVariant294AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant294AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant294AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant294AuthMethod.Email,
                "emu" => UserEventPayloadVariant294AuthMethod.Emu,
                "github" => UserEventPayloadVariant294AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant294AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant294AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant294AuthMethod.Google,
                "invite" => UserEventPayloadVariant294AuthMethod.Invite,
                "manual" => UserEventPayloadVariant294AuthMethod.Manual,
                "otp" => UserEventPayloadVariant294AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant294AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant294AuthMethod.Saml,
                "sms" => UserEventPayloadVariant294AuthMethod.Sms,
                _ => null,
            };
        }
    }
}