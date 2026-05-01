
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant173Update
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
    public static class UserEventPayloadVariant173UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant173Update value)
        {
            return value switch
            {
                UserEventPayloadVariant173Update.ClientId => "clientId",
                UserEventPayloadVariant173Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant173Update.CookieName => "cookieName",
                UserEventPayloadVariant173Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant173Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant173Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant173Update.ClientId,
                "clientSecret" => UserEventPayloadVariant173Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant173Update.CookieName,
                "deploymentType" => UserEventPayloadVariant173Update.DeploymentType,
                "issuer" => UserEventPayloadVariant173Update.Issuer,
                _ => null,
            };
        }
    }
}