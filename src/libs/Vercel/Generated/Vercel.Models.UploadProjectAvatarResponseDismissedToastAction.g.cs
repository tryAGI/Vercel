
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseDismissedToastAction
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
    public static class UploadProjectAvatarResponseDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDismissedToastAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDismissedToastAction.Accept => "accept",
                UploadProjectAvatarResponseDismissedToastAction.Cancel => "cancel",
                UploadProjectAvatarResponseDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => UploadProjectAvatarResponseDismissedToastAction.Accept,
                "cancel" => UploadProjectAvatarResponseDismissedToastAction.Cancel,
                "delete" => UploadProjectAvatarResponseDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}