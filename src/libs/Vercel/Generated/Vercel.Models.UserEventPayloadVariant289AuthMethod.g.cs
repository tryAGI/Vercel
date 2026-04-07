
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant289AuthMethod
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
    public static class UserEventPayloadVariant289AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant289AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant289AuthMethod.App => "app",
                UserEventPayloadVariant289AuthMethod.Apple => "apple",
                UserEventPayloadVariant289AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant289AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant289AuthMethod.Email => "email",
                UserEventPayloadVariant289AuthMethod.Emu => "emu",
                UserEventPayloadVariant289AuthMethod.Github => "github",
                UserEventPayloadVariant289AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant289AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant289AuthMethod.Google => "google",
                UserEventPayloadVariant289AuthMethod.Invite => "invite",
                UserEventPayloadVariant289AuthMethod.Manual => "manual",
                UserEventPayloadVariant289AuthMethod.Otp => "otp",
                UserEventPayloadVariant289AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant289AuthMethod.Saml => "saml",
                UserEventPayloadVariant289AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant289AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant289AuthMethod.App,
                "apple" => UserEventPayloadVariant289AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant289AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant289AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant289AuthMethod.Email,
                "emu" => UserEventPayloadVariant289AuthMethod.Emu,
                "github" => UserEventPayloadVariant289AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant289AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant289AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant289AuthMethod.Google,
                "invite" => UserEventPayloadVariant289AuthMethod.Invite,
                "manual" => UserEventPayloadVariant289AuthMethod.Manual,
                "otp" => UserEventPayloadVariant289AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant289AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant289AuthMethod.Saml,
                "sms" => UserEventPayloadVariant289AuthMethod.Sms,
                _ => null,
            };
        }
    }
}