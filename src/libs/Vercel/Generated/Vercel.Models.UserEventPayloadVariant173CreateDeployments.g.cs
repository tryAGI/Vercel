
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant173CreateDeployments
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
    public static class UserEventPayloadVariant173CreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant173CreateDeployments value)
        {
            return value switch
            {
                UserEventPayloadVariant173CreateDeployments.Disabled => "disabled",
                UserEventPayloadVariant173CreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant173CreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant173CreateDeployments.Disabled,
                "enabled" => UserEventPayloadVariant173CreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}