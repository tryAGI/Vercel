
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833DeliveryVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6df91f8a45eab833DeliveryVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833DeliveryVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833DeliveryVariant1Type.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833DeliveryVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "http" => AutoSDKShared6df91f8a45eab833DeliveryVariant1Type.Http,
                _ => null,
            };
        }
    }
}