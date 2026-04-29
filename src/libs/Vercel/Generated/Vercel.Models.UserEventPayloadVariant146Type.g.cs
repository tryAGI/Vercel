
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant146Type
    {
        /// <summary>
        /// 
        /// </summary>
        Script,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant146TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant146Type value)
        {
            return value switch
            {
                UserEventPayloadVariant146Type.Script => "script",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant146Type? ToEnum(string value)
        {
            return value switch
            {
                "script" => UserEventPayloadVariant146Type.Script,
                _ => null,
            };
        }
    }
}