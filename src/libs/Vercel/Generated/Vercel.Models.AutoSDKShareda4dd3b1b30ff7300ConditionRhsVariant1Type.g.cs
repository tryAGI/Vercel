
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        List,
        /// <summary>
        ///
        /// </summary>
        ListInline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1Type value)
        {
            return value switch
            {
                AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1Type.List => "list",
                AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1Type.List,
                "list/inline" => AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1Type.ListInline,
                _ => null,
            };
        }
    }
}