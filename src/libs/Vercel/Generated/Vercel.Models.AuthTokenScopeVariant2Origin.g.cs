
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthTokenScopeVariant2Origin
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
    public static class AuthTokenScopeVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthTokenScopeVariant2Origin value)
        {
            return value switch
            {
                AuthTokenScopeVariant2Origin.App => "app",
                AuthTokenScopeVariant2Origin.Apple => "apple",
                AuthTokenScopeVariant2Origin.Bitbucket => "bitbucket",
                AuthTokenScopeVariant2Origin.Chatgpt => "chatgpt",
                AuthTokenScopeVariant2Origin.Email => "email",
                AuthTokenScopeVariant2Origin.Emu => "emu",
                AuthTokenScopeVariant2Origin.Github => "github",
                AuthTokenScopeVariant2Origin.GithubWebhook => "github-webhook",
                AuthTokenScopeVariant2Origin.Gitlab => "gitlab",
                AuthTokenScopeVariant2Origin.Google => "google",
                AuthTokenScopeVariant2Origin.Invite => "invite",
                AuthTokenScopeVariant2Origin.Manual => "manual",
                AuthTokenScopeVariant2Origin.Otp => "otp",
                AuthTokenScopeVariant2Origin.Passkey => "passkey",
                AuthTokenScopeVariant2Origin.Saml => "saml",
                AuthTokenScopeVariant2Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthTokenScopeVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => AuthTokenScopeVariant2Origin.App,
                "apple" => AuthTokenScopeVariant2Origin.Apple,
                "bitbucket" => AuthTokenScopeVariant2Origin.Bitbucket,
                "chatgpt" => AuthTokenScopeVariant2Origin.Chatgpt,
                "email" => AuthTokenScopeVariant2Origin.Email,
                "emu" => AuthTokenScopeVariant2Origin.Emu,
                "github" => AuthTokenScopeVariant2Origin.Github,
                "github-webhook" => AuthTokenScopeVariant2Origin.GithubWebhook,
                "gitlab" => AuthTokenScopeVariant2Origin.Gitlab,
                "google" => AuthTokenScopeVariant2Origin.Google,
                "invite" => AuthTokenScopeVariant2Origin.Invite,
                "manual" => AuthTokenScopeVariant2Origin.Manual,
                "otp" => AuthTokenScopeVariant2Origin.Otp,
                "passkey" => AuthTokenScopeVariant2Origin.Passkey,
                "saml" => AuthTokenScopeVariant2Origin.Saml,
                "sms" => AuthTokenScopeVariant2Origin.Sms,
                _ => null,
            };
        }
    }
}