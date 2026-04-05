
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthTokenScopeVariant1Origin
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
    public static class AuthTokenScopeVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthTokenScopeVariant1Origin value)
        {
            return value switch
            {
                AuthTokenScopeVariant1Origin.App => "app",
                AuthTokenScopeVariant1Origin.Apple => "apple",
                AuthTokenScopeVariant1Origin.Bitbucket => "bitbucket",
                AuthTokenScopeVariant1Origin.Chatgpt => "chatgpt",
                AuthTokenScopeVariant1Origin.Email => "email",
                AuthTokenScopeVariant1Origin.Emu => "emu",
                AuthTokenScopeVariant1Origin.Github => "github",
                AuthTokenScopeVariant1Origin.GithubWebhook => "github-webhook",
                AuthTokenScopeVariant1Origin.Gitlab => "gitlab",
                AuthTokenScopeVariant1Origin.Google => "google",
                AuthTokenScopeVariant1Origin.Invite => "invite",
                AuthTokenScopeVariant1Origin.Manual => "manual",
                AuthTokenScopeVariant1Origin.Otp => "otp",
                AuthTokenScopeVariant1Origin.Passkey => "passkey",
                AuthTokenScopeVariant1Origin.Saml => "saml",
                AuthTokenScopeVariant1Origin.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthTokenScopeVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "app" => AuthTokenScopeVariant1Origin.App,
                "apple" => AuthTokenScopeVariant1Origin.Apple,
                "bitbucket" => AuthTokenScopeVariant1Origin.Bitbucket,
                "chatgpt" => AuthTokenScopeVariant1Origin.Chatgpt,
                "email" => AuthTokenScopeVariant1Origin.Email,
                "emu" => AuthTokenScopeVariant1Origin.Emu,
                "github" => AuthTokenScopeVariant1Origin.Github,
                "github-webhook" => AuthTokenScopeVariant1Origin.GithubWebhook,
                "gitlab" => AuthTokenScopeVariant1Origin.Gitlab,
                "google" => AuthTokenScopeVariant1Origin.Google,
                "invite" => AuthTokenScopeVariant1Origin.Invite,
                "manual" => AuthTokenScopeVariant1Origin.Manual,
                "otp" => AuthTokenScopeVariant1Origin.Otp,
                "passkey" => AuthTokenScopeVariant1Origin.Passkey,
                "saml" => AuthTokenScopeVariant1Origin.Saml,
                "sms" => AuthTokenScopeVariant1Origin.Sms,
                _ => null,
            };
        }
    }
}