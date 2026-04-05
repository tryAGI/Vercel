
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant3Action
    {
        /// <summary>
        /// 
        /// </summary>
        Added,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Rotated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant3ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant3Action value)
        {
            return value switch
            {
                UserEventPayloadVariant3Action.Added => "added",
                UserEventPayloadVariant3Action.Deleted => "deleted",
                UserEventPayloadVariant3Action.Rotated => "rotated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant3Action? ToEnum(string value)
        {
            return value switch
            {
                "added" => UserEventPayloadVariant3Action.Added,
                "deleted" => UserEventPayloadVariant3Action.Deleted,
                "rotated" => UserEventPayloadVariant3Action.Rotated,
                _ => null,
            };
        }
    }
}