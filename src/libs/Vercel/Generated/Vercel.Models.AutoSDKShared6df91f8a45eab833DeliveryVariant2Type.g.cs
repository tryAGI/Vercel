
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833DeliveryVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Otlphttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6df91f8a45eab833DeliveryVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833DeliveryVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833DeliveryVariant2Type.Otlphttp => "otlphttp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833DeliveryVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "otlphttp" => AutoSDKShared6df91f8a45eab833DeliveryVariant2Type.Otlphttp,
                _ => null,
            };
        }
    }
}