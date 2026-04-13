
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant144Action
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
    public static class UserEventPayloadVariant144ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant144Action value)
        {
            return value switch
            {
                UserEventPayloadVariant144Action.Disabled => "disabled",
                UserEventPayloadVariant144Action.Enabled => "enabled",
                UserEventPayloadVariant144Action.Regenerated => "regenerated",
                UserEventPayloadVariant144Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant144Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant144Action.Disabled,
                "enabled" => UserEventPayloadVariant144Action.Enabled,
                "regenerated" => UserEventPayloadVariant144Action.Regenerated,
                "updated" => UserEventPayloadVariant144Action.Updated,
                _ => null,
            };
        }
    }
}