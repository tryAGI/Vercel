
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant240Previous
    {
        /// <summary>
        /// 
        /// </summary>
        Elastic,
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant240PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant240Previous.Elastic => "elastic",
                UserEventPayloadVariant240Previous.Enhanced => "enhanced",
                UserEventPayloadVariant240Previous.Standard => "standard",
                UserEventPayloadVariant240Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant240Previous.Elastic,
                "enhanced" => UserEventPayloadVariant240Previous.Enhanced,
                "standard" => UserEventPayloadVariant240Previous.Standard,
                "turbo" => UserEventPayloadVariant240Previous.Turbo,
                _ => null,
            };
        }
    }
}