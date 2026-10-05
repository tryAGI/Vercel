
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3DismissedToastAction
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
    public static class AutoSDKSharede052f139ff613de3DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3DismissedToastAction.Accept => "accept",
                AutoSDKSharede052f139ff613de3DismissedToastAction.Cancel => "cancel",
                AutoSDKSharede052f139ff613de3DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharede052f139ff613de3DismissedToastAction.Accept,
                "cancel" => AutoSDKSharede052f139ff613de3DismissedToastAction.Cancel,
                "delete" => AutoSDKSharede052f139ff613de3DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}