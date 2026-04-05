
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDismissedToastAction
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
    public static class GetProjectResponseDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDismissedToastAction value)
        {
            return value switch
            {
                GetProjectResponseDismissedToastAction.Accept => "accept",
                GetProjectResponseDismissedToastAction.Cancel => "cancel",
                GetProjectResponseDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => GetProjectResponseDismissedToastAction.Accept,
                "cancel" => GetProjectResponseDismissedToastAction.Cancel,
                "delete" => GetProjectResponseDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}