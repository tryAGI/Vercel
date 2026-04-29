
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant168Action
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
    public static class UserEventPayloadVariant168ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant168Action value)
        {
            return value switch
            {
                UserEventPayloadVariant168Action.Disabled => "disabled",
                UserEventPayloadVariant168Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant168Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant168Action.Disabled,
                "enabled" => UserEventPayloadVariant168Action.Enabled,
                _ => null,
            };
        }
    }
}