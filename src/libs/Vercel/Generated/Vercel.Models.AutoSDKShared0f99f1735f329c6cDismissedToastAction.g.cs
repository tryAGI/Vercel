
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f99f1735f329c6cDismissedToastAction
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
    public static class AutoSDKShared0f99f1735f329c6cDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f99f1735f329c6cDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared0f99f1735f329c6cDismissedToastAction.Accept => "accept",
                AutoSDKShared0f99f1735f329c6cDismissedToastAction.Cancel => "cancel",
                AutoSDKShared0f99f1735f329c6cDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f99f1735f329c6cDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared0f99f1735f329c6cDismissedToastAction.Accept,
                "cancel" => AutoSDKShared0f99f1735f329c6cDismissedToastAction.Cancel,
                "delete" => AutoSDKShared0f99f1735f329c6cDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}