
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant144Type
    {
        /// <summary>
        /// 
        /// </summary>
        Script,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant144TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant144Type value)
        {
            return value switch
            {
                UserEventPayloadVariant144Type.Script => "script",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant144Type? ToEnum(string value)
        {
            return value switch
            {
                "script" => UserEventPayloadVariant144Type.Script,
                _ => null,
            };
        }
    }
}