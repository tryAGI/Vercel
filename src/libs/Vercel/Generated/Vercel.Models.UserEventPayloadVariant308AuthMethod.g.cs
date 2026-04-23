
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant308AuthMethod
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
    public static class UserEventPayloadVariant308AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant308AuthMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant308AuthMethod.App => "app",
                UserEventPayloadVariant308AuthMethod.Apple => "apple",
                UserEventPayloadVariant308AuthMethod.Bitbucket => "bitbucket",
                UserEventPayloadVariant308AuthMethod.Chatgpt => "chatgpt",
                UserEventPayloadVariant308AuthMethod.Email => "email",
                UserEventPayloadVariant308AuthMethod.Emu => "emu",
                UserEventPayloadVariant308AuthMethod.Github => "github",
                UserEventPayloadVariant308AuthMethod.GithubWebhook => "github-webhook",
                UserEventPayloadVariant308AuthMethod.Gitlab => "gitlab",
                UserEventPayloadVariant308AuthMethod.Google => "google",
                UserEventPayloadVariant308AuthMethod.Invite => "invite",
                UserEventPayloadVariant308AuthMethod.Manual => "manual",
                UserEventPayloadVariant308AuthMethod.Otp => "otp",
                UserEventPayloadVariant308AuthMethod.Passkey => "passkey",
                UserEventPayloadVariant308AuthMethod.Saml => "saml",
                UserEventPayloadVariant308AuthMethod.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant308AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "app" => UserEventPayloadVariant308AuthMethod.App,
                "apple" => UserEventPayloadVariant308AuthMethod.Apple,
                "bitbucket" => UserEventPayloadVariant308AuthMethod.Bitbucket,
                "chatgpt" => UserEventPayloadVariant308AuthMethod.Chatgpt,
                "email" => UserEventPayloadVariant308AuthMethod.Email,
                "emu" => UserEventPayloadVariant308AuthMethod.Emu,
                "github" => UserEventPayloadVariant308AuthMethod.Github,
                "github-webhook" => UserEventPayloadVariant308AuthMethod.GithubWebhook,
                "gitlab" => UserEventPayloadVariant308AuthMethod.Gitlab,
                "google" => UserEventPayloadVariant308AuthMethod.Google,
                "invite" => UserEventPayloadVariant308AuthMethod.Invite,
                "manual" => UserEventPayloadVariant308AuthMethod.Manual,
                "otp" => UserEventPayloadVariant308AuthMethod.Otp,
                "passkey" => UserEventPayloadVariant308AuthMethod.Passkey,
                "saml" => UserEventPayloadVariant308AuthMethod.Saml,
                "sms" => UserEventPayloadVariant308AuthMethod.Sms,
                _ => null,
            };
        }
    }
}