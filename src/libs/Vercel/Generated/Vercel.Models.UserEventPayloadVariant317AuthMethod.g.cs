
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant317AuthMethod
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
    public static class UserEventPayloadVariant317AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant317AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant317AuthMethod.App => "app",
                UserEventPayloadVariant317AuthMethod.Apple => "apple",
                UserEventPayloadVariant317AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant317AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant317AuthMethod.Email => "email",
                UserEventPayloadVariant317AuthMethod.Emu => "emu",
                UserEventPayloadVariant317AuthMethod.Github => "github",
                UserEventPayloadVariant317AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant317AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant317AuthMethod.Google => "google",
                UserEventPayloadVariant317AuthMethod.Invite => "invite",
                UserEventPayloadVariant317AuthMethod.Manual => "manual",
                UserEventPayloadVariant317AuthMethod.Otp => "otp",
                UserEventPayloadVariant317AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant317AuthMethod.Saml => "saml",
                UserEventPayloadVariant317AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant317AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant317AuthMethod.App,
                "apple" => UserEventPayloadVariant317AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant317AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant317AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant317AuthMethod.Email,
                "emu" => UserEventPayloadVariant317AuthMethod.Emu,
                "github" => UserEventPayloadVariant317AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant317AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant317AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant317AuthMethod.Google,
                "invite" => UserEventPayloadVariant317AuthMethod.Invite,
                "manual" => UserEventPayloadVariant317AuthMethod.Manual,
                "otp" => UserEventPayloadVariant317AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant317AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant317AuthMethod.Saml,
                "sms" => UserEventPayloadVariant317AuthMethod.Sms,
                _ => null,
            };
        }
    }
}