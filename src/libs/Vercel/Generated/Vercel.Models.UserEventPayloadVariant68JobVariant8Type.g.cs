
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant68JobVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        VercelPush,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant68JobVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant68JobVariant8Type value)
        {
            return value switch
            {
                UserEventPayloadVariant68JobVariant8Type.VercelPush => "vercel-push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant68JobVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel-push" => UserEventPayloadVariant68JobVariant8Type.VercelPush,
                _ => null,
            };
        }
    }
}