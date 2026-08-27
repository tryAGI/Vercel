
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseTargetsChecksState
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Registered,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseTargetsChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTargetsChecksState value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTargetsChecksState.Completed => "completed",
                UploadProjectAvatarResponseTargetsChecksState.Registered => "registered",
                UploadProjectAvatarResponseTargetsChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTargetsChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UploadProjectAvatarResponseTargetsChecksState.Completed,
                "registered" => UploadProjectAvatarResponseTargetsChecksState.Registered,
                "running" => UploadProjectAvatarResponseTargetsChecksState.Running,
                _ => null,
            };
        }
    }
}