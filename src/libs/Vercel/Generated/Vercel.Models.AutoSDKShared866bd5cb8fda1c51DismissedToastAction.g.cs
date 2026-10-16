
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51DismissedToastAction
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
    public static class AutoSDKShared866bd5cb8fda1c51DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51DismissedToastAction.Accept => "accept",
                AutoSDKShared866bd5cb8fda1c51DismissedToastAction.Cancel => "cancel",
                AutoSDKShared866bd5cb8fda1c51DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared866bd5cb8fda1c51DismissedToastAction.Accept,
                "cancel" => AutoSDKShared866bd5cb8fda1c51DismissedToastAction.Cancel,
                "delete" => AutoSDKShared866bd5cb8fda1c51DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}