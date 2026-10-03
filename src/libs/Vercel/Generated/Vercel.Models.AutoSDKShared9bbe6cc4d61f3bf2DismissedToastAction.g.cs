
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction.Accept => "accept",
                AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction.Cancel => "cancel",
                AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction.Accept,
                "cancel" => AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction.Cancel,
                "delete" => AutoSDKShared9bbe6cc4d61f3bf2DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}