
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant158Update
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
    public static class UserEventPayloadVariant158UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant158Update value)
        {
            return value switch
            {
                UserEventPayloadVariant158Update.ClientId => "clientId",
                UserEventPayloadVariant158Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant158Update.CookieName => "cookieName",
                UserEventPayloadVariant158Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant158Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant158Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant158Update.ClientId,
                "clientSecret" => UserEventPayloadVariant158Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant158Update.CookieName,
                "deploymentType" => UserEventPayloadVariant158Update.DeploymentType,
                "issuer" => UserEventPayloadVariant158Update.Issuer,
                _ => null,
            };
        }
    }
}