
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant1Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant1Provider.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant70JobVariant1Provider.Bitbucket,
                _ => null,
            };
        }
    }
}