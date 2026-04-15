
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant159Action
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
    public static class UserEventPayloadVariant159ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant159Action value)
        {
            return value switch
            {
                UserEventPayloadVariant159Action.Disabled => "disabled",
                UserEventPayloadVariant159Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant159Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant159Action.Disabled,
                "enabled" => UserEventPayloadVariant159Action.Enabled,
                _ => null,
            };
        }
    }
}