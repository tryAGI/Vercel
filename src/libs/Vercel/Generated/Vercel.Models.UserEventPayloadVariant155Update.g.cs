
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant155Update
    {
        /// <summary>
        /// 
        /// </summary>
        ClientId,
        /// <summary>
        /// 
        /// </summary>
        ClientSecret,
        /// <summary>
        /// 
        /// </summary>
        CookieName,
        /// <summary>
        /// 
        /// </summary>
        DeploymentType,
        /// <summary>
        /// 
        /// </summary>
        Issuer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant155UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant155Update value)
        {
            return value switch
            {
                UserEventPayloadVariant155Update.ClientId => "clientId",
                UserEventPayloadVariant155Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant155Update.CookieName => "cookieName",
                UserEventPayloadVariant155Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant155Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant155Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant155Update.ClientId,
                "clientSecret" => UserEventPayloadVariant155Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant155Update.CookieName,
                "deploymentType" => UserEventPayloadVariant155Update.DeploymentType,
                "issuer" => UserEventPayloadVariant155Update.Issuer,
                _ => null,
            };
        }
    }
}