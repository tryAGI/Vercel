
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant40Action
    {
        /// <summary>
        /// 
        /// </summary>
        Mutate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant40ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant40Action value)
        {
            return value switch
            {
                UserEventPayloadVariant40Action.Mutate => "mutate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant40Action? ToEnum(string value)
        {
            return value switch
            {
                "mutate" => UserEventPayloadVariant40Action.Mutate,
                _ => null,
            };
        }
    }
}