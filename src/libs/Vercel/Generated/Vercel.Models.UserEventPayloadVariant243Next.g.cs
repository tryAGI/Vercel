
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant243Next
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
    public static class UserEventPayloadVariant243NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant243Next value)
        {
            return value switch
            {
                UserEventPayloadVariant243Next.Elastic => "elastic",
                UserEventPayloadVariant243Next.Enhanced => "enhanced",
                UserEventPayloadVariant243Next.Standard => "standard",
                UserEventPayloadVariant243Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant243Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant243Next.Elastic,
                "enhanced" => UserEventPayloadVariant243Next.Enhanced,
                "standard" => UserEventPayloadVariant243Next.Standard,
                "turbo" => UserEventPayloadVariant243Next.Turbo,
                _ => null,
            };
        }
    }
}