
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant305AuthMethod
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
    public static class UserEventPayloadVariant305AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant305AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant305AuthMethod.App => "app",
                UserEventPayloadVariant305AuthMethod.Apple => "apple",
                UserEventPayloadVariant305AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant305AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant305AuthMethod.Email => "email",
                UserEventPayloadVariant305AuthMethod.Emu => "emu",
                UserEventPayloadVariant305AuthMethod.Github => "github",
                UserEventPayloadVariant305AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant305AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant305AuthMethod.Google => "google",
                UserEventPayloadVariant305AuthMethod.Invite => "invite",
                UserEventPayloadVariant305AuthMethod.Manual => "manual",
                UserEventPayloadVariant305AuthMethod.Otp => "otp",
                UserEventPayloadVariant305AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant305AuthMethod.Saml => "saml",
                UserEventPayloadVariant305AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant305AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant305AuthMethod.App,
                "apple" => UserEventPayloadVariant305AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant305AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant305AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant305AuthMethod.Email,
                "emu" => UserEventPayloadVariant305AuthMethod.Emu,
                "github" => UserEventPayloadVariant305AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant305AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant305AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant305AuthMethod.Google,
                "invite" => UserEventPayloadVariant305AuthMethod.Invite,
                "manual" => UserEventPayloadVariant305AuthMethod.Manual,
                "otp" => UserEventPayloadVariant305AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant305AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant305AuthMethod.Saml,
                "sms" => UserEventPayloadVariant305AuthMethod.Sms,
                _ => null,
            };
        }
    }
}