
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant148Action
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
    public static class UserEventPayloadVariant148ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant148Action value)
        {
            return value switch
            {
                UserEventPayloadVariant148Action.Disabled => "disabled",
                UserEventPayloadVariant148Action.Enabled => "enabled",
                UserEventPayloadVariant148Action.Regenerated => "regenerated",
                UserEventPayloadVariant148Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant148Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant148Action.Disabled,
                "enabled" => UserEventPayloadVariant148Action.Enabled,
                "regenerated" => UserEventPayloadVariant148Action.Regenerated,
                "updated" => UserEventPayloadVariant148Action.Updated,
                _ => null,
            };
        }
    }
}