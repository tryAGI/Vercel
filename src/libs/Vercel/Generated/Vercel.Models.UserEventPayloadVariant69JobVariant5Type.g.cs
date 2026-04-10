
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant69JobVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        NowComment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant69JobVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant69JobVariant5Type value)
        {
            return value switch
            {
                UserEventPayloadVariant69JobVariant5Type.NowComment => "now-comment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant69JobVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "now-comment" => UserEventPayloadVariant69JobVariant5Type.NowComment,
                _ => null,
            };
        }
    }
}