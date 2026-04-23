
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant161Action
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
    public static class UserEventPayloadVariant161ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant161Action value)
        {
            return value switch
            {
                UserEventPayloadVariant161Action.Disabled => "disabled",
                UserEventPayloadVariant161Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant161Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant161Action.Disabled,
                "enabled" => UserEventPayloadVariant161Action.Enabled,
                _ => null,
            };
        }
    }
}