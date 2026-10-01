
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eDismissedToastAction
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
    public static class AutoSDKSharede27e7ff1aa86f19eDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eDismissedToastAction.Accept => "accept",
                AutoSDKSharede27e7ff1aa86f19eDismissedToastAction.Cancel => "cancel",
                AutoSDKSharede27e7ff1aa86f19eDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharede27e7ff1aa86f19eDismissedToastAction.Accept,
                "cancel" => AutoSDKSharede27e7ff1aa86f19eDismissedToastAction.Cancel,
                "delete" => AutoSDKSharede27e7ff1aa86f19eDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}