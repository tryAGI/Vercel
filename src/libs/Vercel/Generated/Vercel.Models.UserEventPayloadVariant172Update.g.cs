
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant172Update
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
    public static class UserEventPayloadVariant172UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant172Update value)
        {
            return value switch
            {
                UserEventPayloadVariant172Update.ClientId => "clientId",
                UserEventPayloadVariant172Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant172Update.CookieName => "cookieName",
                UserEventPayloadVariant172Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant172Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant172Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant172Update.ClientId,
                "clientSecret" => UserEventPayloadVariant172Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant172Update.CookieName,
                "deploymentType" => UserEventPayloadVariant172Update.DeploymentType,
                "issuer" => UserEventPayloadVariant172Update.Issuer,
                _ => null,
            };
        }
    }
}