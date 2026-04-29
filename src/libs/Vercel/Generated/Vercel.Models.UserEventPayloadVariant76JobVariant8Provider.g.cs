
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant76JobVariant8Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant76JobVariant8ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant76JobVariant8Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant76JobVariant8Provider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant76JobVariant8Provider? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => UserEventPayloadVariant76JobVariant8Provider.Vercel,
                _ => null,
            };
        }
    }
}