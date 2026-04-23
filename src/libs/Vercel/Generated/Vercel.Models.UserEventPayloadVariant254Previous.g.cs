
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant254Previous
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
    public static class UserEventPayloadVariant254PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant254Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant254Previous.Elastic => "elastic",
                UserEventPayloadVariant254Previous.Enhanced => "enhanced",
                UserEventPayloadVariant254Previous.Standard => "standard",
                UserEventPayloadVariant254Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant254Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant254Previous.Elastic,
                "enhanced" => UserEventPayloadVariant254Previous.Enhanced,
                "standard" => UserEventPayloadVariant254Previous.Standard,
                "turbo" => UserEventPayloadVariant254Previous.Turbo,
                _ => null,
            };
        }
    }
}