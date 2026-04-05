
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the toast was dismissed, the action was accepted, or the dismissal with this key should be removed
    /// </summary>
    public enum UpdateProjectRequestDismissedToastAction
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
    public static class UpdateProjectRequestDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDismissedToastAction value)
        {
            return value switch
            {
                UpdateProjectRequestDismissedToastAction.Accept => "accept",
                UpdateProjectRequestDismissedToastAction.Cancel => "cancel",
                UpdateProjectRequestDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => UpdateProjectRequestDismissedToastAction.Accept,
                "cancel" => UpdateProjectRequestDismissedToastAction.Cancel,
                "delete" => UpdateProjectRequestDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}