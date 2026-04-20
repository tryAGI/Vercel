
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant251Next
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
    public static class UserEventPayloadVariant251NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251Next value)
        {
            return value switch
            {
                UserEventPayloadVariant251Next.Elastic => "elastic",
                UserEventPayloadVariant251Next.Enhanced => "enhanced",
                UserEventPayloadVariant251Next.Standard => "standard",
                UserEventPayloadVariant251Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant251Next.Elastic,
                "enhanced" => UserEventPayloadVariant251Next.Enhanced,
                "standard" => UserEventPayloadVariant251Next.Standard,
                "turbo" => UserEventPayloadVariant251Next.Turbo,
                _ => null,
            };
        }
    }
}