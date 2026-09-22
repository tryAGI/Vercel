
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared04b58f4753dd761fConditionRhsVariant1Type
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
    public static class AutoSDKShared04b58f4753dd761fConditionRhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared04b58f4753dd761fConditionRhsVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared04b58f4753dd761fConditionRhsVariant1Type.List => "list",
                AutoSDKShared04b58f4753dd761fConditionRhsVariant1Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared04b58f4753dd761fConditionRhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => AutoSDKShared04b58f4753dd761fConditionRhsVariant1Type.List,
                "list/inline" => AutoSDKShared04b58f4753dd761fConditionRhsVariant1Type.ListInline,
                _ => null,
            };
        }
    }
}