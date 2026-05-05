
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266Next
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
    public static class UserEventPayloadVariant266NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266Next value)
        {
            return value switch
            {
                UserEventPayloadVariant266Next.Elastic => "elastic",
                UserEventPayloadVariant266Next.Enhanced => "enhanced",
                UserEventPayloadVariant266Next.Standard => "standard",
                UserEventPayloadVariant266Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant266Next.Elastic,
                "enhanced" => UserEventPayloadVariant266Next.Enhanced,
                "standard" => UserEventPayloadVariant266Next.Standard,
                "turbo" => UserEventPayloadVariant266Next.Turbo,
                _ => null,
            };
        }
    }
}