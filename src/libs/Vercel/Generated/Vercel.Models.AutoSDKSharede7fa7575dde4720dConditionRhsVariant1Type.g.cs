
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7fa7575dde4720dConditionRhsVariant1Type
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
    public static class AutoSDKSharede7fa7575dde4720dConditionRhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7fa7575dde4720dConditionRhsVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharede7fa7575dde4720dConditionRhsVariant1Type.List => "list",
                AutoSDKSharede7fa7575dde4720dConditionRhsVariant1Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7fa7575dde4720dConditionRhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => AutoSDKSharede7fa7575dde4720dConditionRhsVariant1Type.List,
                "list/inline" => AutoSDKSharede7fa7575dde4720dConditionRhsVariant1Type.ListInline,
                _ => null,
            };
        }
    }
}