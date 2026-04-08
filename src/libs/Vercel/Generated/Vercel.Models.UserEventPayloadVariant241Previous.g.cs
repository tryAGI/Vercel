
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant241Previous
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
    public static class UserEventPayloadVariant241PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant241Previous.Elastic => "elastic",
                UserEventPayloadVariant241Previous.Enhanced => "enhanced",
                UserEventPayloadVariant241Previous.Standard => "standard",
                UserEventPayloadVariant241Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant241Previous.Elastic,
                "enhanced" => UserEventPayloadVariant241Previous.Enhanced,
                "standard" => UserEventPayloadVariant241Previous.Standard,
                "turbo" => UserEventPayloadVariant241Previous.Turbo,
                _ => null,
            };
        }
    }
}