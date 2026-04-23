
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant163Update
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
    public static class UserEventPayloadVariant163UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant163Update value)
        {
            return value switch
            {
                UserEventPayloadVariant163Update.ClientId => "clientId",
                UserEventPayloadVariant163Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant163Update.CookieName => "cookieName",
                UserEventPayloadVariant163Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant163Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant163Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant163Update.ClientId,
                "clientSecret" => UserEventPayloadVariant163Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant163Update.CookieName,
                "deploymentType" => UserEventPayloadVariant163Update.DeploymentType,
                "issuer" => UserEventPayloadVariant163Update.Issuer,
                _ => null,
            };
        }
    }
}