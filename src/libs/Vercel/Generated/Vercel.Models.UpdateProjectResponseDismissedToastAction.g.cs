
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDismissedToastAction
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
    public static class UpdateProjectResponseDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDismissedToastAction value)
        {
            return value switch
            {
                UpdateProjectResponseDismissedToastAction.Accept => "accept",
                UpdateProjectResponseDismissedToastAction.Cancel => "cancel",
                UpdateProjectResponseDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => UpdateProjectResponseDismissedToastAction.Accept,
                "cancel" => UpdateProjectResponseDismissedToastAction.Cancel,
                "delete" => UpdateProjectResponseDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}