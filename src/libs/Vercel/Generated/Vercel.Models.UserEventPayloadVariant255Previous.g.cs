
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255Previous
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
    public static class UserEventPayloadVariant255PreviousExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255Previous value)
        {
            return value switch
            {
                UserEventPayloadVariant255Previous.Elastic => "elastic",
                UserEventPayloadVariant255Previous.Enhanced => "enhanced",
                UserEventPayloadVariant255Previous.Standard => "standard",
                UserEventPayloadVariant255Previous.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255Previous? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant255Previous.Elastic,
                "enhanced" => UserEventPayloadVariant255Previous.Enhanced,
                "standard" => UserEventPayloadVariant255Previous.Standard,
                "turbo" => UserEventPayloadVariant255Previous.Turbo,
                _ => null,
            };
        }
    }
}