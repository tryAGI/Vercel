
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant19Action
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
    public static class UserEventPayloadVariant19ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant19Action value)
        {
            return value switch
            {
                UserEventPayloadVariant19Action.Created => "created",
                UserEventPayloadVariant19Action.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant19Action? ToEnum(string value)
        {
            return value switch
            {
                "created" => UserEventPayloadVariant19Action.Created,
                "removed" => UserEventPayloadVariant19Action.Removed,
                _ => null,
            };
        }
    }
}