
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant293AuthMethod
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
    public static class UserEventPayloadVariant293AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant293AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant293AuthMethod.App => "app",
                UserEventPayloadVariant293AuthMethod.Apple => "apple",
                UserEventPayloadVariant293AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant293AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant293AuthMethod.Email => "email",
                UserEventPayloadVariant293AuthMethod.Emu => "emu",
                UserEventPayloadVariant293AuthMethod.Github => "github",
                UserEventPayloadVariant293AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant293AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant293AuthMethod.Google => "google",
                UserEventPayloadVariant293AuthMethod.Invite => "invite",
                UserEventPayloadVariant293AuthMethod.Manual => "manual",
                UserEventPayloadVariant293AuthMethod.Otp => "otp",
                UserEventPayloadVariant293AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant293AuthMethod.Saml => "saml",
                UserEventPayloadVariant293AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant293AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant293AuthMethod.App,
                "apple" => UserEventPayloadVariant293AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant293AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant293AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant293AuthMethod.Email,
                "emu" => UserEventPayloadVariant293AuthMethod.Emu,
                "github" => UserEventPayloadVariant293AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant293AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant293AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant293AuthMethod.Google,
                "invite" => UserEventPayloadVariant293AuthMethod.Invite,
                "manual" => UserEventPayloadVariant293AuthMethod.Manual,
                "otp" => UserEventPayloadVariant293AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant293AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant293AuthMethod.Saml,
                "sms" => UserEventPayloadVariant293AuthMethod.Sms,
                _ => null,
            };
        }
    }
}