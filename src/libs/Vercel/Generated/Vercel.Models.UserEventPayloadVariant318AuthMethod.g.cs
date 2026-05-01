
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant318AuthMethod
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
    public static class UserEventPayloadVariant318AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant318AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant318AuthMethod.App => "app",
                UserEventPayloadVariant318AuthMethod.Apple => "apple",
                UserEventPayloadVariant318AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant318AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant318AuthMethod.Email => "email",
                UserEventPayloadVariant318AuthMethod.Emu => "emu",
                UserEventPayloadVariant318AuthMethod.Github => "github",
                UserEventPayloadVariant318AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant318AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant318AuthMethod.Google => "google",
                UserEventPayloadVariant318AuthMethod.Invite => "invite",
                UserEventPayloadVariant318AuthMethod.Manual => "manual",
                UserEventPayloadVariant318AuthMethod.Otp => "otp",
                UserEventPayloadVariant318AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant318AuthMethod.Saml => "saml",
                UserEventPayloadVariant318AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant318AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant318AuthMethod.App,
                "apple" => UserEventPayloadVariant318AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant318AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant318AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant318AuthMethod.Email,
                "emu" => UserEventPayloadVariant318AuthMethod.Emu,
                "github" => UserEventPayloadVariant318AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant318AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant318AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant318AuthMethod.Google,
                "invite" => UserEventPayloadVariant318AuthMethod.Invite,
                "manual" => UserEventPayloadVariant318AuthMethod.Manual,
                "otp" => UserEventPayloadVariant318AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant318AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant318AuthMethod.Saml,
                "sms" => UserEventPayloadVariant318AuthMethod.Sms,
                _ => null,
            };
        }
    }
}