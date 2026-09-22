
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9e46425f35715a0ConditionRhsVariant3Type
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
    public static class AutoSDKSharedd9e46425f35715a0ConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9e46425f35715a0ConditionRhsVariant3Type value)
        {
            return value switch
            {
                AutoSDKSharedd9e46425f35715a0ConditionRhsVariant3Type.List => "list",
                AutoSDKSharedd9e46425f35715a0ConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9e46425f35715a0ConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => AutoSDKSharedd9e46425f35715a0ConditionRhsVariant3Type.List,
                "list/inline" => AutoSDKSharedd9e46425f35715a0ConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}