
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant162Action
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
    public static class UserEventPayloadVariant162ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant162Action value)
        {
            return value switch
            {
                UserEventPayloadVariant162Action.Disabled => "disabled",
                UserEventPayloadVariant162Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant162Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant162Action.Disabled,
                "enabled" => UserEventPayloadVariant162Action.Enabled,
                _ => null,
            };
        }
    }
}