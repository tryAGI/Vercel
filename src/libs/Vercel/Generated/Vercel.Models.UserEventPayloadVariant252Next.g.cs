
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant252Next
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
    public static class UserEventPayloadVariant252NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252Next value)
        {
            return value switch
            {
                UserEventPayloadVariant252Next.Elastic => "elastic",
                UserEventPayloadVariant252Next.Enhanced => "enhanced",
                UserEventPayloadVariant252Next.Standard => "standard",
                UserEventPayloadVariant252Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant252Next.Elastic,
                "enhanced" => UserEventPayloadVariant252Next.Enhanced,
                "standard" => UserEventPayloadVariant252Next.Standard,
                "turbo" => UserEventPayloadVariant252Next.Turbo,
                _ => null,
            };
        }
    }
}