
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f45691814810f14ConditionLhsVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f45691814810f14ConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f45691814810f14ConditionLhsVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared0f45691814810f14ConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f45691814810f14ConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AutoSDKShared0f45691814810f14ConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}