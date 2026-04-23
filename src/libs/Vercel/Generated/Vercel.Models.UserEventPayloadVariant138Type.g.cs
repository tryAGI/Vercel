
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant138Type
    {
        /// <summary>
        /// 
        /// </summary>
        Script,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant138TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant138Type value)
        {
            return value switch
            {
                UserEventPayloadVariant138Type.Script => "script",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant138Type? ToEnum(string value)
        {
            return value switch
            {
                "script" => UserEventPayloadVariant138Type.Script,
                _ => null,
            };
        }
    }
}