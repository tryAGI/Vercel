
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant150Action
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Regenerated,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant150ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant150Action value)
        {
            return value switch
            {
                UserEventPayloadVariant150Action.Disabled => "disabled",
                UserEventPayloadVariant150Action.Enabled => "enabled",
                UserEventPayloadVariant150Action.Regenerated => "regenerated",
                UserEventPayloadVariant150Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant150Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant150Action.Disabled,
                "enabled" => UserEventPayloadVariant150Action.Enabled,
                "regenerated" => UserEventPayloadVariant150Action.Regenerated,
                "updated" => UserEventPayloadVariant150Action.Updated,
                _ => null,
            };
        }
    }
}