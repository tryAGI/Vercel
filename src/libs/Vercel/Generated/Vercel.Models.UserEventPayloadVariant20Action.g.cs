
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant20Action
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
    public static class UserEventPayloadVariant20ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant20Action value)
        {
            return value switch
            {
                UserEventPayloadVariant20Action.Created => "created",
                UserEventPayloadVariant20Action.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant20Action? ToEnum(string value)
        {
            return value switch
            {
                "created" => UserEventPayloadVariant20Action.Created,
                "removed" => UserEventPayloadVariant20Action.Removed,
                _ => null,
            };
        }
    }
}