
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244Next
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
    public static class UserEventPayloadVariant244NextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244Next value)
        {
            return value switch
            {
                UserEventPayloadVariant244Next.Elastic => "elastic",
                UserEventPayloadVariant244Next.Enhanced => "enhanced",
                UserEventPayloadVariant244Next.Standard => "standard",
                UserEventPayloadVariant244Next.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244Next? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant244Next.Elastic,
                "enhanced" => UserEventPayloadVariant244Next.Enhanced,
                "standard" => UserEventPayloadVariant244Next.Standard,
                "turbo" => UserEventPayloadVariant244Next.Turbo,
                _ => null,
            };
        }
    }
}