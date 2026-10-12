
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbDismissedToastAction
    {
        /// <summary>
        ///
        /// </summary>
        Accept,
        /// <summary>
        ///
        /// </summary>
        Cancel,
        /// <summary>
        ///
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedba7c6b12ca723bfbDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbDismissedToastAction.Accept => "accept",
                AutoSDKSharedba7c6b12ca723bfbDismissedToastAction.Cancel => "cancel",
                AutoSDKSharedba7c6b12ca723bfbDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedba7c6b12ca723bfbDismissedToastAction.Accept,
                "cancel" => AutoSDKSharedba7c6b12ca723bfbDismissedToastAction.Cancel,
                "delete" => AutoSDKSharedba7c6b12ca723bfbDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}