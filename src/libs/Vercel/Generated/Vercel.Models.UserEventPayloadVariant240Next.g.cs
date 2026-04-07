
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant240Next
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
    public static class UserEventPayloadVariant240NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240Next value)
        {
            return value switch
            {
                UserEventPayloadVariant240Next.Elastic => "elastic",
                UserEventPayloadVariant240Next.Enhanced => "enhanced",
                UserEventPayloadVariant240Next.Standard => "standard",
                UserEventPayloadVariant240Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant240Next.Elastic,
                "enhanced" => UserEventPayloadVariant240Next.Enhanced,
                "standard" => UserEventPayloadVariant240Next.Standard,
                "turbo" => UserEventPayloadVariant240Next.Turbo,
                _ => null,
            };
        }
    }
}