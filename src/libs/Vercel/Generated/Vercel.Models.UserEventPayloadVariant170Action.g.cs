
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant170Action
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
    public static class UserEventPayloadVariant170ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant170Action value)
        {
            return value switch
            {
                UserEventPayloadVariant170Action.Disabled => "disabled",
                UserEventPayloadVariant170Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant170Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant170Action.Disabled,
                "enabled" => UserEventPayloadVariant170Action.Enabled,
                _ => null,
            };
        }
    }
}