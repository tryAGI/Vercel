
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264Next
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
    public static class UserEventPayloadVariant264NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264Next value)
        {
            return value switch
            {
                UserEventPayloadVariant264Next.Elastic => "elastic",
                UserEventPayloadVariant264Next.Enhanced => "enhanced",
                UserEventPayloadVariant264Next.Standard => "standard",
                UserEventPayloadVariant264Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant264Next.Elastic,
                "enhanced" => UserEventPayloadVariant264Next.Enhanced,
                "standard" => UserEventPayloadVariant264Next.Standard,
                "turbo" => UserEventPayloadVariant264Next.Turbo,
                _ => null,
            };
        }
    }
}