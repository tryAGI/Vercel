
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479DismissedToastAction
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
    public static class AutoSDKShareda2d284b091a73479DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479DismissedToastAction.Accept => "accept",
                AutoSDKShareda2d284b091a73479DismissedToastAction.Cancel => "cancel",
                AutoSDKShareda2d284b091a73479DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShareda2d284b091a73479DismissedToastAction.Accept,
                "cancel" => AutoSDKShareda2d284b091a73479DismissedToastAction.Cancel,
                "delete" => AutoSDKShareda2d284b091a73479DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}