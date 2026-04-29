
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant47Action
    {
        /// <summary>
        /// 
        /// </summary>
        Mutate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant47ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant47Action value)
        {
            return value switch
            {
                UserEventPayloadVariant47Action.Mutate => "mutate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant47Action? ToEnum(string value)
        {
            return value switch
            {
                "mutate" => UserEventPayloadVariant47Action.Mutate,
                _ => null,
            };
        }
    }
}