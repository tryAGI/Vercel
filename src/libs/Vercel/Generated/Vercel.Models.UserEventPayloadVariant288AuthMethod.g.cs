
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant288AuthMethod
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
    public static class UserEventPayloadVariant288AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant288AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant288AuthMethod.App => "app",
                UserEventPayloadVariant288AuthMethod.Apple => "apple",
                UserEventPayloadVariant288AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant288AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant288AuthMethod.Email => "email",
                UserEventPayloadVariant288AuthMethod.Emu => "emu",
                UserEventPayloadVariant288AuthMethod.Github => "github",
                UserEventPayloadVariant288AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant288AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant288AuthMethod.Google => "google",
                UserEventPayloadVariant288AuthMethod.Invite => "invite",
                UserEventPayloadVariant288AuthMethod.Manual => "manual",
                UserEventPayloadVariant288AuthMethod.Otp => "otp",
                UserEventPayloadVariant288AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant288AuthMethod.Saml => "saml",
                UserEventPayloadVariant288AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant288AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant288AuthMethod.App,
                "apple" => UserEventPayloadVariant288AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant288AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant288AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant288AuthMethod.Email,
                "emu" => UserEventPayloadVariant288AuthMethod.Emu,
                "github" => UserEventPayloadVariant288AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant288AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant288AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant288AuthMethod.Google,
                "invite" => UserEventPayloadVariant288AuthMethod.Invite,
                "manual" => UserEventPayloadVariant288AuthMethod.Manual,
                "otp" => UserEventPayloadVariant288AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant288AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant288AuthMethod.Saml,
                "sms" => UserEventPayloadVariant288AuthMethod.Sms,
                _ => null,
            };
        }
    }
}