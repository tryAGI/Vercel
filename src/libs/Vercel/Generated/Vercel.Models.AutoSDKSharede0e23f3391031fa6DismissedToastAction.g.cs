
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6DismissedToastAction
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
    public static class AutoSDKSharede0e23f3391031fa6DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6DismissedToastAction.Accept => "accept",
                AutoSDKSharede0e23f3391031fa6DismissedToastAction.Cancel => "cancel",
                AutoSDKSharede0e23f3391031fa6DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharede0e23f3391031fa6DismissedToastAction.Accept,
                "cancel" => AutoSDKSharede0e23f3391031fa6DismissedToastAction.Cancel,
                "delete" => AutoSDKSharede0e23f3391031fa6DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}