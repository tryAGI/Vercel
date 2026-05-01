
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant171Action
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
    public static class UserEventPayloadVariant171ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant171Action value)
        {
            return value switch
            {
                UserEventPayloadVariant171Action.Disabled => "disabled",
                UserEventPayloadVariant171Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant171Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant171Action.Disabled,
                "enabled" => UserEventPayloadVariant171Action.Enabled,
                _ => null,
            };
        }
    }
}