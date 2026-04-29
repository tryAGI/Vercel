
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant170Update
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
    public static class UserEventPayloadVariant170UpdateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant170Update value)
        {
            return value switch
            {
                UserEventPayloadVariant170Update.ClientId => "clientId",
                UserEventPayloadVariant170Update.ClientSecret => "clientSecret",
                UserEventPayloadVariant170Update.CookieName => "cookieName",
                UserEventPayloadVariant170Update.DeploymentType => "deploymentType",
                UserEventPayloadVariant170Update.Issuer => "issuer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant170Update? ToEnum(string value)
        {
            return value switch
            {
                "clientId" => UserEventPayloadVariant170Update.ClientId,
                "clientSecret" => UserEventPayloadVariant170Update.ClientSecret,
                "cookieName" => UserEventPayloadVariant170Update.CookieName,
                "deploymentType" => UserEventPayloadVariant170Update.DeploymentType,
                "issuer" => UserEventPayloadVariant170Update.Issuer,
                _ => null,
            };
        }
    }
}