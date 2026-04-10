
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant69JobVariant2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant69JobVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant69JobVariant2Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant69JobVariant2Provider.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant69JobVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant69JobVariant2Provider.Bitbucket,
                _ => null,
            };
        }
    }
}