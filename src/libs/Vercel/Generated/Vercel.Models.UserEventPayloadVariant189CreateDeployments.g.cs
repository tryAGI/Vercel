
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant189CreateDeployments
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
    public static class UserEventPayloadVariant189CreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant189CreateDeployments value)
        {
            return value switch
            {
                UserEventPayloadVariant189CreateDeployments.Disabled => "disabled",
                UserEventPayloadVariant189CreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant189CreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant189CreateDeployments.Disabled,
                "enabled" => UserEventPayloadVariant189CreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}