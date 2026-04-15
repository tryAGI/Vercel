
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant299AuthMethod
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
    public static class UserEventPayloadVariant299AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant299AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant299AuthMethod.App => "app",
                UserEventPayloadVariant299AuthMethod.Apple => "apple",
                UserEventPayloadVariant299AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant299AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant299AuthMethod.Email => "email",
                UserEventPayloadVariant299AuthMethod.Emu => "emu",
                UserEventPayloadVariant299AuthMethod.Github => "github",
                UserEventPayloadVariant299AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant299AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant299AuthMethod.Google => "google",
                UserEventPayloadVariant299AuthMethod.Invite => "invite",
                UserEventPayloadVariant299AuthMethod.Manual => "manual",
                UserEventPayloadVariant299AuthMethod.Otp => "otp",
                UserEventPayloadVariant299AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant299AuthMethod.Saml => "saml",
                UserEventPayloadVariant299AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant299AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant299AuthMethod.App,
                "apple" => UserEventPayloadVariant299AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant299AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant299AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant299AuthMethod.Email,
                "emu" => UserEventPayloadVariant299AuthMethod.Emu,
                "github" => UserEventPayloadVariant299AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant299AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant299AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant299AuthMethod.Google,
                "invite" => UserEventPayloadVariant299AuthMethod.Invite,
                "manual" => UserEventPayloadVariant299AuthMethod.Manual,
                "otp" => UserEventPayloadVariant299AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant299AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant299AuthMethod.Saml,
                "sms" => UserEventPayloadVariant299AuthMethod.Sms,
                _ => null,
            };
        }
    }
}