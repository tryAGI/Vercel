
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bDismissedToastAction
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
    public static class AutoSDKShared26233794f6c8981bDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bDismissedToastAction.Accept => "accept",
                AutoSDKShared26233794f6c8981bDismissedToastAction.Cancel => "cancel",
                AutoSDKShared26233794f6c8981bDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared26233794f6c8981bDismissedToastAction.Accept,
                "cancel" => AutoSDKShared26233794f6c8981bDismissedToastAction.Cancel,
                "delete" => AutoSDKShared26233794f6c8981bDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}