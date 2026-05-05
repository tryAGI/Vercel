
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant319AuthMethod
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
    public static class UserEventPayloadVariant319AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant319AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant319AuthMethod.App => "app",
                UserEventPayloadVariant319AuthMethod.Apple => "apple",
                UserEventPayloadVariant319AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant319AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant319AuthMethod.Email => "email",
                UserEventPayloadVariant319AuthMethod.Emu => "emu",
                UserEventPayloadVariant319AuthMethod.Github => "github",
                UserEventPayloadVariant319AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant319AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant319AuthMethod.Google => "google",
                UserEventPayloadVariant319AuthMethod.Invite => "invite",
                UserEventPayloadVariant319AuthMethod.Manual => "manual",
                UserEventPayloadVariant319AuthMethod.Otp => "otp",
                UserEventPayloadVariant319AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant319AuthMethod.Saml => "saml",
                UserEventPayloadVariant319AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant319AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant319AuthMethod.App,
                "apple" => UserEventPayloadVariant319AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant319AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant319AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant319AuthMethod.Email,
                "emu" => UserEventPayloadVariant319AuthMethod.Emu,
                "github" => UserEventPayloadVariant319AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant319AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant319AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant319AuthMethod.Google,
                "invite" => UserEventPayloadVariant319AuthMethod.Invite,
                "manual" => UserEventPayloadVariant319AuthMethod.Manual,
                "otp" => UserEventPayloadVariant319AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant319AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant319AuthMethod.Saml,
                "sms" => UserEventPayloadVariant319AuthMethod.Sms,
                _ => null,
            };
        }
    }
}