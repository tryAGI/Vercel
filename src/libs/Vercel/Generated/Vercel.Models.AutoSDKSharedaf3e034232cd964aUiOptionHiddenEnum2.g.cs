
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2
    {
        /// <summary>
        ///
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2 value)
        {
            return value switch
            {
                AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2.Create => "create",
                AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2.Create,
                "update" => AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2.Update,
                _ => null,
            };
        }
    }
}