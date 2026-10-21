
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8DismissedToastAction
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
    public static class AutoSDKShared0d52d5fc16437df8DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8DismissedToastAction.Accept => "accept",
                AutoSDKShared0d52d5fc16437df8DismissedToastAction.Cancel => "cancel",
                AutoSDKShared0d52d5fc16437df8DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared0d52d5fc16437df8DismissedToastAction.Accept,
                "cancel" => AutoSDKShared0d52d5fc16437df8DismissedToastAction.Cancel,
                "delete" => AutoSDKShared0d52d5fc16437df8DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}