
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7DismissedToastAction
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
    public static class AutoSDKShared061b01d29a72e8d7DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7DismissedToastAction.Accept => "accept",
                AutoSDKShared061b01d29a72e8d7DismissedToastAction.Cancel => "cancel",
                AutoSDKShared061b01d29a72e8d7DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared061b01d29a72e8d7DismissedToastAction.Accept,
                "cancel" => AutoSDKShared061b01d29a72e8d7DismissedToastAction.Cancel,
                "delete" => AutoSDKShared061b01d29a72e8d7DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}