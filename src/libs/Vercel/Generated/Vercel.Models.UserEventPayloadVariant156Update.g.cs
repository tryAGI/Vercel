
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant156Update
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
    public static class UserEventPayloadVariant156UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant156Update value)
        {
            return value switch
            {
                UserEventPayloadVariant156Update.ClientId => "clientId",
                UserEventPayloadVariant156Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant156Update.CookieName => "cookieName",
                UserEventPayloadVariant156Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant156Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant156Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant156Update.ClientId,
                "clientSecret" => UserEventPayloadVariant156Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant156Update.CookieName,
                "deploymentType" => UserEventPayloadVariant156Update.DeploymentType,
                "issuer" => UserEventPayloadVariant156Update.Issuer,
                _ => null,
            };
        }
    }
}