
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant290AuthMethod
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
    public static class UserEventPayloadVariant290AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant290AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant290AuthMethod.App => "app",
                UserEventPayloadVariant290AuthMethod.Apple => "apple",
                UserEventPayloadVariant290AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant290AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant290AuthMethod.Email => "email",
                UserEventPayloadVariant290AuthMethod.Emu => "emu",
                UserEventPayloadVariant290AuthMethod.Github => "github",
                UserEventPayloadVariant290AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant290AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant290AuthMethod.Google => "google",
                UserEventPayloadVariant290AuthMethod.Invite => "invite",
                UserEventPayloadVariant290AuthMethod.Manual => "manual",
                UserEventPayloadVariant290AuthMethod.Otp => "otp",
                UserEventPayloadVariant290AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant290AuthMethod.Saml => "saml",
                UserEventPayloadVariant290AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant290AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant290AuthMethod.App,
                "apple" => UserEventPayloadVariant290AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant290AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant290AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant290AuthMethod.Email,
                "emu" => UserEventPayloadVariant290AuthMethod.Emu,
                "github" => UserEventPayloadVariant290AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant290AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant290AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant290AuthMethod.Google,
                "invite" => UserEventPayloadVariant290AuthMethod.Invite,
                "manual" => UserEventPayloadVariant290AuthMethod.Manual,
                "otp" => UserEventPayloadVariant290AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant290AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant290AuthMethod.Saml,
                "sms" => UserEventPayloadVariant290AuthMethod.Sms,
                _ => null,
            };
        }
    }
}