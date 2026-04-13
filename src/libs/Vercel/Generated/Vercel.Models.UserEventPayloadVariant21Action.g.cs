
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant21Action
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
    public static class UserEventPayloadVariant21ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant21Action value)
        {
            return value switch
            {
                UserEventPayloadVariant21Action.Created => "created",
                UserEventPayloadVariant21Action.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant21Action? ToEnum(string value)
        {
            return value switch
            {
                "created" => UserEventPayloadVariant21Action.Created,
                "removed" => UserEventPayloadVariant21Action.Removed,
                _ => null,
            };
        }
    }
}