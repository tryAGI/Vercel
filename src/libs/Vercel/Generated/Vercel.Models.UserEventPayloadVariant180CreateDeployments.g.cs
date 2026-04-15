
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant180CreateDeployments
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
    public static class UserEventPayloadVariant180CreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant180CreateDeployments value)
        {
            return value switch
            {
                UserEventPayloadVariant180CreateDeployments.Disabled => "disabled",
                UserEventPayloadVariant180CreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant180CreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant180CreateDeployments.Disabled,
                "enabled" => UserEventPayloadVariant180CreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}