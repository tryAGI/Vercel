
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedaf3e034232cd964aUiControl
    {
        /// <summary>
        ///
        /// </summary>
        MultiSelect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedaf3e034232cd964aUiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedaf3e034232cd964aUiControl value)
        {
            return value switch
            {
                AutoSDKSharedaf3e034232cd964aUiControl.MultiSelect => "multi-select",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedaf3e034232cd964aUiControl? ToEnum(string value)
        {
            return value switch
            {
                "multi-select" => AutoSDKSharedaf3e034232cd964aUiControl.MultiSelect,
                _ => null,
            };
        }
    }
}