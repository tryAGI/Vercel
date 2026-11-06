
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa8b687d5ac48c48DismissedToastAction
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
    public static class AutoSDKSharedfa8b687d5ac48c48DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa8b687d5ac48c48DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedfa8b687d5ac48c48DismissedToastAction.Accept => "accept",
                AutoSDKSharedfa8b687d5ac48c48DismissedToastAction.Cancel => "cancel",
                AutoSDKSharedfa8b687d5ac48c48DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa8b687d5ac48c48DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedfa8b687d5ac48c48DismissedToastAction.Accept,
                "cancel" => AutoSDKSharedfa8b687d5ac48c48DismissedToastAction.Cancel,
                "delete" => AutoSDKSharedfa8b687d5ac48c48DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}