
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9e46425f35715a0ConditionLhsVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd9e46425f35715a0ConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9e46425f35715a0ConditionLhsVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharedd9e46425f35715a0ConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9e46425f35715a0ConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AutoSDKSharedd9e46425f35715a0ConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}