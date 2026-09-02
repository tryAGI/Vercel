
#nullable enable

namespace Vercel
{
    /// <summary>
    /// done means the external service was updated. required means the Vercel update was saved, but provider-side configuration still needs attention.
    /// </summary>
    public enum ConnectServiceSyncStatus
    {
        /// <summary>
        ///
        /// </summary>
        Done,
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectServiceSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectServiceSyncStatus value)
        {
            return value switch
            {
                ConnectServiceSyncStatus.Done => "done",
                ConnectServiceSyncStatus.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectServiceSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => ConnectServiceSyncStatus.Done,
                "required" => ConnectServiceSyncStatus.Required,
                _ => null,
            };
        }
    }
}