
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39497871754bda72DismissedToastAction
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
    public static class AutoSDKShared39497871754bda72DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39497871754bda72DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared39497871754bda72DismissedToastAction.Accept => "accept",
                AutoSDKShared39497871754bda72DismissedToastAction.Cancel => "cancel",
                AutoSDKShared39497871754bda72DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39497871754bda72DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared39497871754bda72DismissedToastAction.Accept,
                "cancel" => AutoSDKShared39497871754bda72DismissedToastAction.Cancel,
                "delete" => AutoSDKShared39497871754bda72DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}