
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant151Action
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
    public static class UserEventPayloadVariant151ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant151Action value)
        {
            return value switch
            {
                UserEventPayloadVariant151Action.Disabled => "disabled",
                UserEventPayloadVariant151Action.Enabled => "enabled",
                UserEventPayloadVariant151Action.Regenerated => "regenerated",
                UserEventPayloadVariant151Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant151Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant151Action.Disabled,
                "enabled" => UserEventPayloadVariant151Action.Enabled,
                "regenerated" => UserEventPayloadVariant151Action.Regenerated,
                "updated" => UserEventPayloadVariant151Action.Updated,
                _ => null,
            };
        }
    }
}