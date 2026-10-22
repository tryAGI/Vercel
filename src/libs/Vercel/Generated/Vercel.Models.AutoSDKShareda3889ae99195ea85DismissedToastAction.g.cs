
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85DismissedToastAction
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
    public static class AutoSDKShareda3889ae99195ea85DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85DismissedToastAction.Accept => "accept",
                AutoSDKShareda3889ae99195ea85DismissedToastAction.Cancel => "cancel",
                AutoSDKShareda3889ae99195ea85DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShareda3889ae99195ea85DismissedToastAction.Accept,
                "cancel" => AutoSDKShareda3889ae99195ea85DismissedToastAction.Cancel,
                "delete" => AutoSDKShareda3889ae99195ea85DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}