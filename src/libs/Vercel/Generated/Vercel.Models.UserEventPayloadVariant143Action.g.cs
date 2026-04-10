
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant143Action
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
    public static class UserEventPayloadVariant143ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant143Action value)
        {
            return value switch
            {
                UserEventPayloadVariant143Action.Disabled => "disabled",
                UserEventPayloadVariant143Action.Enabled => "enabled",
                UserEventPayloadVariant143Action.Regenerated => "regenerated",
                UserEventPayloadVariant143Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant143Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant143Action.Disabled,
                "enabled" => UserEventPayloadVariant143Action.Enabled,
                "regenerated" => UserEventPayloadVariant143Action.Regenerated,
                "updated" => UserEventPayloadVariant143Action.Updated,
                _ => null,
            };
        }
    }
}