
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared52fb994527107e75DismissedToastAction
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
    public static class AutoSDKShared52fb994527107e75DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75DismissedToastAction.Accept => "accept",
                AutoSDKShared52fb994527107e75DismissedToastAction.Cancel => "cancel",
                AutoSDKShared52fb994527107e75DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared52fb994527107e75DismissedToastAction.Accept,
                "cancel" => AutoSDKShared52fb994527107e75DismissedToastAction.Cancel,
                "delete" => AutoSDKShared52fb994527107e75DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}