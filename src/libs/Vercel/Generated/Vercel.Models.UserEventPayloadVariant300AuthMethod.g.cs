
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant300AuthMethod
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
    public static class UserEventPayloadVariant300AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant300AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant300AuthMethod.App => "app",
                UserEventPayloadVariant300AuthMethod.Apple => "apple",
                UserEventPayloadVariant300AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant300AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant300AuthMethod.Email => "email",
                UserEventPayloadVariant300AuthMethod.Emu => "emu",
                UserEventPayloadVariant300AuthMethod.Github => "github",
                UserEventPayloadVariant300AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant300AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant300AuthMethod.Google => "google",
                UserEventPayloadVariant300AuthMethod.Invite => "invite",
                UserEventPayloadVariant300AuthMethod.Manual => "manual",
                UserEventPayloadVariant300AuthMethod.Otp => "otp",
                UserEventPayloadVariant300AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant300AuthMethod.Saml => "saml",
                UserEventPayloadVariant300AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant300AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant300AuthMethod.App,
                "apple" => UserEventPayloadVariant300AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant300AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant300AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant300AuthMethod.Email,
                "emu" => UserEventPayloadVariant300AuthMethod.Emu,
                "github" => UserEventPayloadVariant300AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant300AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant300AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant300AuthMethod.Google,
                "invite" => UserEventPayloadVariant300AuthMethod.Invite,
                "manual" => UserEventPayloadVariant300AuthMethod.Manual,
                "otp" => UserEventPayloadVariant300AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant300AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant300AuthMethod.Saml,
                "sms" => UserEventPayloadVariant300AuthMethod.Sms,
                _ => null,
            };
        }
    }
}