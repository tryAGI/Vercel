
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aDismissedToastAction
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
    public static class AutoSDKSharedc734cd9afdf7614aDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aDismissedToastAction.Accept => "accept",
                AutoSDKSharedc734cd9afdf7614aDismissedToastAction.Cancel => "cancel",
                AutoSDKSharedc734cd9afdf7614aDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedc734cd9afdf7614aDismissedToastAction.Accept,
                "cancel" => AutoSDKSharedc734cd9afdf7614aDismissedToastAction.Cancel,
                "delete" => AutoSDKSharedc734cd9afdf7614aDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}