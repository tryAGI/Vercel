
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedce53ae034203eae7ConditionLhsVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedce53ae034203eae7ConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedce53ae034203eae7ConditionLhsVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharedce53ae034203eae7ConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedce53ae034203eae7ConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AutoSDKSharedce53ae034203eae7ConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}