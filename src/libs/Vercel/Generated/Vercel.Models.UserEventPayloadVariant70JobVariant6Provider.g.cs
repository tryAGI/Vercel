
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant6Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant6ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant6Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant6Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant6Provider? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => UserEventPayloadVariant70JobVariant6Provider.Gitlab,
                _ => null,
            };
        }
    }
}