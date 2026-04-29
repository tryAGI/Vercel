
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant27Action
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant27ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant27Action value)
        {
            return value switch
            {
                UserEventPayloadVariant27Action.Created => "created",
                UserEventPayloadVariant27Action.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant27Action? ToEnum(string value)
        {
            return value switch
            {
                "created" => UserEventPayloadVariant27Action.Created,
                "removed" => UserEventPayloadVariant27Action.Removed,
                _ => null,
            };
        }
    }
}