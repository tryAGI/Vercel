
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type
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
    public static class AutoSDKSharedce53ae034203eae7ConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type value)
        {
            return value switch
            {
                AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type.List => "list",
                AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type.List,
                "list/inline" => AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}