
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant291AuthMethod
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
    public static class UserEventPayloadVariant291AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant291AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant291AuthMethod.App => "app",
                UserEventPayloadVariant291AuthMethod.Apple => "apple",
                UserEventPayloadVariant291AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant291AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant291AuthMethod.Email => "email",
                UserEventPayloadVariant291AuthMethod.Emu => "emu",
                UserEventPayloadVariant291AuthMethod.Github => "github",
                UserEventPayloadVariant291AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant291AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant291AuthMethod.Google => "google",
                UserEventPayloadVariant291AuthMethod.Invite => "invite",
                UserEventPayloadVariant291AuthMethod.Manual => "manual",
                UserEventPayloadVariant291AuthMethod.Otp => "otp",
                UserEventPayloadVariant291AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant291AuthMethod.Saml => "saml",
                UserEventPayloadVariant291AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant291AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant291AuthMethod.App,
                "apple" => UserEventPayloadVariant291AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant291AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant291AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant291AuthMethod.Email,
                "emu" => UserEventPayloadVariant291AuthMethod.Emu,
                "github" => UserEventPayloadVariant291AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant291AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant291AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant291AuthMethod.Google,
                "invite" => UserEventPayloadVariant291AuthMethod.Invite,
                "manual" => UserEventPayloadVariant291AuthMethod.Manual,
                "otp" => UserEventPayloadVariant291AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant291AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant291AuthMethod.Saml,
                "sms" => UserEventPayloadVariant291AuthMethod.Sms,
                _ => null,
            };
        }
    }
}