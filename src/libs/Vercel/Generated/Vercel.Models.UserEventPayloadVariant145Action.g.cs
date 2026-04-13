
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant145Action
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
    public static class UserEventPayloadVariant145ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant145Action value)
        {
            return value switch
            {
                UserEventPayloadVariant145Action.Disabled => "disabled",
                UserEventPayloadVariant145Action.Enabled => "enabled",
                UserEventPayloadVariant145Action.Regenerated => "regenerated",
                UserEventPayloadVariant145Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant145Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant145Action.Disabled,
                "enabled" => UserEventPayloadVariant145Action.Enabled,
                "regenerated" => UserEventPayloadVariant145Action.Regenerated,
                "updated" => UserEventPayloadVariant145Action.Updated,
                _ => null,
            };
        }
    }
}