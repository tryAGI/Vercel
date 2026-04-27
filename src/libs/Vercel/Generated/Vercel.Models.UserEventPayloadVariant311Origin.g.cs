
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant311Origin
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
    public static class UserEventPayloadVariant311OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant311Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant311Origin.App => "app",
                UserEventPayloadVariant311Origin.Apple => "apple",
                UserEventPayloadVariant311Origin.Bitbucket => "bitbucket",
                UserEventPayloadVariant311Origin.Chatgpt => "chatgpt",
                UserEventPayloadVariant311Origin.Email => "email",
                UserEventPayloadVariant311Origin.Emu => "emu",
                UserEventPayloadVariant311Origin.Github => "github",
                UserEventPayloadVariant311Origin.GithubWebhook => "github-webhook",
                UserEventPayloadVariant311Origin.Gitlab => "gitlab",
                UserEventPayloadVariant311Origin.Google => "google",
                UserEventPayloadVariant311Origin.Invite => "invite",
                UserEventPayloadVariant311Origin.Manual => "manual",
                UserEventPayloadVariant311Origin.Otp => "otp",
                UserEventPayloadVariant311Origin.Passkey => "passkey",
                UserEventPayloadVariant311Origin.Saml => "saml",
                UserEventPayloadVariant311Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant311Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant311Origin.App,
                "apple" => UserEventPayloadVariant311Origin.Apple,
                "bitbucket" => UserEventPayloadVariant311Origin.Bitbucket,
                "chatgpt" => UserEventPayloadVariant311Origin.Chatgpt,
                "email" => UserEventPayloadVariant311Origin.Email,
                "emu" => UserEventPayloadVariant311Origin.Emu,
                "github" => UserEventPayloadVariant311Origin.Github,
                "github-webhook" => UserEventPayloadVariant311Origin.GithubWebhook,
                "gitlab" => UserEventPayloadVariant311Origin.Gitlab,
                "google" => UserEventPayloadVariant311Origin.Google,
                "invite" => UserEventPayloadVariant311Origin.Invite,
                "manual" => UserEventPayloadVariant311Origin.Manual,
                "otp" => UserEventPayloadVariant311Origin.Otp,
                "passkey" => UserEventPayloadVariant311Origin.Passkey,
                "saml" => UserEventPayloadVariant311Origin.Saml,
                "sms" => UserEventPayloadVariant311Origin.Sms,
                _ => null,
            };
        }
    }
}