
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared100e7eb80f0eb492DismissedToastAction
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
    public static class AutoSDKShared100e7eb80f0eb492DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared100e7eb80f0eb492DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared100e7eb80f0eb492DismissedToastAction.Accept => "accept",
                AutoSDKShared100e7eb80f0eb492DismissedToastAction.Cancel => "cancel",
                AutoSDKShared100e7eb80f0eb492DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared100e7eb80f0eb492DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared100e7eb80f0eb492DismissedToastAction.Accept,
                "cancel" => AutoSDKShared100e7eb80f0eb492DismissedToastAction.Cancel,
                "delete" => AutoSDKShared100e7eb80f0eb492DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}