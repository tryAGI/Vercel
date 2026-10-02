
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4DismissedToastAction
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
    public static class AutoSDKSharedfe1f84289679c6c4DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4DismissedToastAction.Accept => "accept",
                AutoSDKSharedfe1f84289679c6c4DismissedToastAction.Cancel => "cancel",
                AutoSDKSharedfe1f84289679c6c4DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedfe1f84289679c6c4DismissedToastAction.Accept,
                "cancel" => AutoSDKSharedfe1f84289679c6c4DismissedToastAction.Cancel,
                "delete" => AutoSDKSharedfe1f84289679c6c4DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}