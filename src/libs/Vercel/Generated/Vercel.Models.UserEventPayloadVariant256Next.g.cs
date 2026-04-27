
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256Next
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
    public static class UserEventPayloadVariant256NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256Next value)
        {
            return value switch
            {
                UserEventPayloadVariant256Next.Elastic => "elastic",
                UserEventPayloadVariant256Next.Enhanced => "enhanced",
                UserEventPayloadVariant256Next.Standard => "standard",
                UserEventPayloadVariant256Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant256Next.Elastic,
                "enhanced" => UserEventPayloadVariant256Next.Enhanced,
                "standard" => UserEventPayloadVariant256Next.Standard,
                "turbo" => UserEventPayloadVariant256Next.Turbo,
                _ => null,
            };
        }
    }
}