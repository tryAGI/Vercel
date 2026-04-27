
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant183CreateDeployments
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant183CreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant183CreateDeployments value)
        {
            return value switch
            {
                UserEventPayloadVariant183CreateDeployments.Disabled => "disabled",
                UserEventPayloadVariant183CreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant183CreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant183CreateDeployments.Disabled,
                "enabled" => UserEventPayloadVariant183CreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}