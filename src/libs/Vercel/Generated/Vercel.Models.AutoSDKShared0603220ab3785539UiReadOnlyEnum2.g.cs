
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0603220ab3785539UiReadOnlyEnum2
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
    public static class AutoSDKShared0603220ab3785539UiReadOnlyEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0603220ab3785539UiReadOnlyEnum2 value)
        {
            return value switch
            {
                AutoSDKShared0603220ab3785539UiReadOnlyEnum2.Create => "create",
                AutoSDKShared0603220ab3785539UiReadOnlyEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0603220ab3785539UiReadOnlyEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => AutoSDKShared0603220ab3785539UiReadOnlyEnum2.Create,
                "update" => AutoSDKShared0603220ab3785539UiReadOnlyEnum2.Update,
                _ => null,
            };
        }
    }
}