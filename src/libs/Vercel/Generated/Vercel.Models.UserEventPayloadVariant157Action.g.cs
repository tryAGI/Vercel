
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant157Action
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
    public static class UserEventPayloadVariant157ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant157Action value)
        {
            return value switch
            {
                UserEventPayloadVariant157Action.Disabled => "disabled",
                UserEventPayloadVariant157Action.Enabled => "enabled",
                UserEventPayloadVariant157Action.Regenerated => "regenerated",
                UserEventPayloadVariant157Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant157Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant157Action.Disabled,
                "enabled" => UserEventPayloadVariant157Action.Enabled,
                "regenerated" => UserEventPayloadVariant157Action.Regenerated,
                "updated" => UserEventPayloadVariant157Action.Updated,
                _ => null,
            };
        }
    }
}