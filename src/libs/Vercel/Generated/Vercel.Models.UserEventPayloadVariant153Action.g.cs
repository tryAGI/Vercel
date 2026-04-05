
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant153Action
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
    public static class UserEventPayloadVariant153ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant153Action value)
        {
            return value switch
            {
                UserEventPayloadVariant153Action.Disabled => "disabled",
                UserEventPayloadVariant153Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant153Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant153Action.Disabled,
                "enabled" => UserEventPayloadVariant153Action.Enabled,
                _ => null,
            };
        }
    }
}