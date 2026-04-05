
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant239Next
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
    public static class UserEventPayloadVariant239NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239Next value)
        {
            return value switch
            {
                UserEventPayloadVariant239Next.Elastic => "elastic",
                UserEventPayloadVariant239Next.Enhanced => "enhanced",
                UserEventPayloadVariant239Next.Standard => "standard",
                UserEventPayloadVariant239Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant239Next.Elastic,
                "enhanced" => UserEventPayloadVariant239Next.Enhanced,
                "standard" => UserEventPayloadVariant239Next.Standard,
                "turbo" => UserEventPayloadVariant239Next.Turbo,
                _ => null,
            };
        }
    }
}