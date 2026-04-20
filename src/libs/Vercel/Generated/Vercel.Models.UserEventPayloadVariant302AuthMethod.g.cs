
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant302AuthMethod
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
    public static class UserEventPayloadVariant302AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant302AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant302AuthMethod.App => "app",
                UserEventPayloadVariant302AuthMethod.Apple => "apple",
                UserEventPayloadVariant302AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant302AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant302AuthMethod.Email => "email",
                UserEventPayloadVariant302AuthMethod.Emu => "emu",
                UserEventPayloadVariant302AuthMethod.Github => "github",
                UserEventPayloadVariant302AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant302AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant302AuthMethod.Google => "google",
                UserEventPayloadVariant302AuthMethod.Invite => "invite",
                UserEventPayloadVariant302AuthMethod.Manual => "manual",
                UserEventPayloadVariant302AuthMethod.Otp => "otp",
                UserEventPayloadVariant302AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant302AuthMethod.Saml => "saml",
                UserEventPayloadVariant302AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant302AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant302AuthMethod.App,
                "apple" => UserEventPayloadVariant302AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant302AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant302AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant302AuthMethod.Email,
                "emu" => UserEventPayloadVariant302AuthMethod.Emu,
                "github" => UserEventPayloadVariant302AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant302AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant302AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant302AuthMethod.Google,
                "invite" => UserEventPayloadVariant302AuthMethod.Invite,
                "manual" => UserEventPayloadVariant302AuthMethod.Manual,
                "otp" => UserEventPayloadVariant302AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant302AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant302AuthMethod.Saml,
                "sms" => UserEventPayloadVariant302AuthMethod.Sms,
                _ => null,
            };
        }
    }
}