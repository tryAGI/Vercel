
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217DeliveryVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0695a89a4e02b217DeliveryVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217DeliveryVariant5Type value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217DeliveryVariant5Type.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217DeliveryVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "internal" => AutoSDKShared0695a89a4e02b217DeliveryVariant5Type.Internal,
                _ => null,
            };
        }
    }
}