
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Unarchived,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant2Action value)
        {
            return value switch
            {
                UserEventPayloadVariant2Action.Archived => "archived",
                UserEventPayloadVariant2Action.Created => "created",
                UserEventPayloadVariant2Action.Deleted => "deleted",
                UserEventPayloadVariant2Action.Unarchived => "unarchived",
                UserEventPayloadVariant2Action.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "archived" => UserEventPayloadVariant2Action.Archived,
                "created" => UserEventPayloadVariant2Action.Created,
                "deleted" => UserEventPayloadVariant2Action.Deleted,
                "unarchived" => UserEventPayloadVariant2Action.Unarchived,
                "updated" => UserEventPayloadVariant2Action.Updated,
                _ => null,
            };
        }
    }
}