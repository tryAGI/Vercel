
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant8Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant8ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant8Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant8Provider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant8Provider? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => UserEventPayloadVariant70JobVariant8Provider.Vercel,
                _ => null,
            };
        }
    }
}