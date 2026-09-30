
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51DismissedToastAction
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
    public static class AutoSDKSharedea12f8422dc06e51DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51DismissedToastAction.Accept => "accept",
                AutoSDKSharedea12f8422dc06e51DismissedToastAction.Cancel => "cancel",
                AutoSDKSharedea12f8422dc06e51DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedea12f8422dc06e51DismissedToastAction.Accept,
                "cancel" => AutoSDKSharedea12f8422dc06e51DismissedToastAction.Cancel,
                "delete" => AutoSDKSharedea12f8422dc06e51DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}