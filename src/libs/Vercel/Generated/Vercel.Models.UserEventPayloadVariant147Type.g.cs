
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant147Type
    {
        /// <summary>
        /// 
        /// </summary>
        Script,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant147TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant147Type value)
        {
            return value switch
            {
                UserEventPayloadVariant147Type.Script => "script",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant147Type? ToEnum(string value)
        {
            return value switch
            {
                "script" => UserEventPayloadVariant147Type.Script,
                _ => null,
            };
        }
    }
}