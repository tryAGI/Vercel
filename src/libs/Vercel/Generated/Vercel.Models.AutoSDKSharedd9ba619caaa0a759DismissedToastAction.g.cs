
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759DismissedToastAction
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
    public static class AutoSDKSharedd9ba619caaa0a759DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759DismissedToastAction.Accept => "accept",
                AutoSDKSharedd9ba619caaa0a759DismissedToastAction.Cancel => "cancel",
                AutoSDKSharedd9ba619caaa0a759DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedd9ba619caaa0a759DismissedToastAction.Accept,
                "cancel" => AutoSDKSharedd9ba619caaa0a759DismissedToastAction.Cancel,
                "delete" => AutoSDKSharedd9ba619caaa0a759DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}