
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant161Update
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
    public static class UserEventPayloadVariant161UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant161Update value)
        {
            return value switch
            {
                UserEventPayloadVariant161Update.ClientId => "clientId",
                UserEventPayloadVariant161Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant161Update.CookieName => "cookieName",
                UserEventPayloadVariant161Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant161Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant161Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant161Update.ClientId,
                "clientSecret" => UserEventPayloadVariant161Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant161Update.CookieName,
                "deploymentType" => UserEventPayloadVariant161Update.DeploymentType,
                "issuer" => UserEventPayloadVariant161Update.Issuer,
                _ => null,
            };
        }
    }
}