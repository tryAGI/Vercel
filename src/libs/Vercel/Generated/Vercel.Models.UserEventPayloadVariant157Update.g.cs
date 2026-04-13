
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant157Update
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
    public static class UserEventPayloadVariant157UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant157Update value)
        {
            return value switch
            {
                UserEventPayloadVariant157Update.ClientId => "clientId",
                UserEventPayloadVariant157Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant157Update.CookieName => "cookieName",
                UserEventPayloadVariant157Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant157Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant157Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant157Update.ClientId,
                "clientSecret" => UserEventPayloadVariant157Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant157Update.CookieName,
                "deploymentType" => UserEventPayloadVariant157Update.DeploymentType,
                "issuer" => UserEventPayloadVariant157Update.Issuer,
                _ => null,
            };
        }
    }
}