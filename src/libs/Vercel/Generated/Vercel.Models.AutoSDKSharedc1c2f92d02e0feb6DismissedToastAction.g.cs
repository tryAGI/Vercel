
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction
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
    public static class AutoSDKSharedc1c2f92d02e0feb6DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction.Accept => "accept",
                AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction.Cancel => "cancel",
                AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction.Accept,
                "cancel" => AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction.Cancel,
                "delete" => AutoSDKSharedc1c2f92d02e0feb6DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}