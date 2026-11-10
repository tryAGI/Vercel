
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDeliveryVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcDeliveryVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDeliveryVariant5Type value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant5Type.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDeliveryVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "internal" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant5Type.Internal,
                _ => null,
            };
        }
    }
}