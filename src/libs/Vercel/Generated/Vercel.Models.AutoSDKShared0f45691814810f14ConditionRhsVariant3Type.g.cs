
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f45691814810f14ConditionRhsVariant3Type
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
    public static class AutoSDKShared0f45691814810f14ConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f45691814810f14ConditionRhsVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared0f45691814810f14ConditionRhsVariant3Type.List => "list",
                AutoSDKShared0f45691814810f14ConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f45691814810f14ConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => AutoSDKShared0f45691814810f14ConditionRhsVariant3Type.List,
                "list/inline" => AutoSDKShared0f45691814810f14ConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}