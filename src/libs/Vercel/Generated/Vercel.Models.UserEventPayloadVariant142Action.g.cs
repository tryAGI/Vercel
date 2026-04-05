
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant142Action
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
    public static class UserEventPayloadVariant142ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant142Action value)
        {
            return value switch
            {
                UserEventPayloadVariant142Action.Disabled => "disabled",
                UserEventPayloadVariant142Action.Enabled => "enabled",
                UserEventPayloadVariant142Action.Regenerated => "regenerated",
                UserEventPayloadVariant142Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant142Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant142Action.Disabled,
                "enabled" => UserEventPayloadVariant142Action.Enabled,
                "regenerated" => UserEventPayloadVariant142Action.Regenerated,
                "updated" => UserEventPayloadVariant142Action.Updated,
                _ => null,
            };
        }
    }
}