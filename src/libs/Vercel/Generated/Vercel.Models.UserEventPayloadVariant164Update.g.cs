
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant164Update
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
    public static class UserEventPayloadVariant164UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant164Update value)
        {
            return value switch
            {
                UserEventPayloadVariant164Update.ClientId => "clientId",
                UserEventPayloadVariant164Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant164Update.CookieName => "cookieName",
                UserEventPayloadVariant164Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant164Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant164Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant164Update.ClientId,
                "clientSecret" => UserEventPayloadVariant164Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant164Update.CookieName,
                "deploymentType" => UserEventPayloadVariant164Update.DeploymentType,
                "issuer" => UserEventPayloadVariant164Update.Issuer,
                _ => null,
            };
        }
    }
}