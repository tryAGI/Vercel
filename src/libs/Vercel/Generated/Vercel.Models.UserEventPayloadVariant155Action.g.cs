
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant155Action
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
    public static class UserEventPayloadVariant155ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant155Action value)
        {
            return value switch
            {
                UserEventPayloadVariant155Action.Disabled => "disabled",
                UserEventPayloadVariant155Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant155Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant155Action.Disabled,
                "enabled" => UserEventPayloadVariant155Action.Enabled,
                _ => null,
            };
        }
    }
}