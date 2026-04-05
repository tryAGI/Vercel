
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant171CreateDeployments
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
    public static class UserEventPayloadVariant171CreateDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant171CreateDeployments value)
        {
            return value switch
            {
                UserEventPayloadVariant171CreateDeployments.Disabled => "disabled",
                UserEventPayloadVariant171CreateDeployments.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant171CreateDeployments? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant171CreateDeployments.Disabled,
                "enabled" => UserEventPayloadVariant171CreateDeployments.Enabled,
                _ => null,
            };
        }
    }
}