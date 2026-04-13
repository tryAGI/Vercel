
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant41Action
    {
        /// <summary>
        /// 
        /// </summary>
        Mutate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant41ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant41Action value)
        {
            return value switch
            {
                UserEventPayloadVariant41Action.Mutate => "mutate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant41Action? ToEnum(string value)
        {
            return value switch
            {
                "mutate" => UserEventPayloadVariant41Action.Mutate,
                _ => null,
            };
        }
    }
}