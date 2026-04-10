
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant69JobVariant7Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant69JobVariant7ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant69JobVariant7Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant69JobVariant7Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant69JobVariant7Provider? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => UserEventPayloadVariant69JobVariant7Provider.Gitlab,
                _ => null,
            };
        }
    }
}