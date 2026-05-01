
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant160Action
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
    public static class UserEventPayloadVariant160ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant160Action value)
        {
            return value switch
            {
                UserEventPayloadVariant160Action.Disabled => "disabled",
                UserEventPayloadVariant160Action.Enabled => "enabled",
                UserEventPayloadVariant160Action.Regenerated => "regenerated",
                UserEventPayloadVariant160Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant160Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant160Action.Disabled,
                "enabled" => UserEventPayloadVariant160Action.Enabled,
                "regenerated" => UserEventPayloadVariant160Action.Regenerated,
                "updated" => UserEventPayloadVariant160Action.Updated,
                _ => null,
            };
        }
    }
}