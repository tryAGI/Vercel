
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant156Action
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
    public static class UserEventPayloadVariant156ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant156Action value)
        {
            return value switch
            {
                UserEventPayloadVariant156Action.Disabled => "disabled",
                UserEventPayloadVariant156Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant156Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant156Action.Disabled,
                "enabled" => UserEventPayloadVariant156Action.Enabled,
                _ => null,
            };
        }
    }
}