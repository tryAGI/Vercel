
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant76JobVariant7Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant76JobVariant7ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant76JobVariant7Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant76JobVariant7Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant76JobVariant7Provider? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => UserEventPayloadVariant76JobVariant7Provider.Gitlab,
                _ => null,
            };
        }
    }
}