
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7DismissedToastAction
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
    public static class AutoSDKSharedf5934c240f4382f7DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7DismissedToastAction.Accept => "accept",
                AutoSDKSharedf5934c240f4382f7DismissedToastAction.Cancel => "cancel",
                AutoSDKSharedf5934c240f4382f7DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedf5934c240f4382f7DismissedToastAction.Accept,
                "cancel" => AutoSDKSharedf5934c240f4382f7DismissedToastAction.Cancel,
                "delete" => AutoSDKSharedf5934c240f4382f7DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}