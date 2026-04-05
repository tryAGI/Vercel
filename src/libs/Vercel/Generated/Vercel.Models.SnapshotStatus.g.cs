
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The status of the snapshot.<br/>
    /// Example: created
    /// </summary>
    public enum SnapshotStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnapshotStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnapshotStatus value)
        {
            return value switch
            {
                SnapshotStatus.Created => "created",
                SnapshotStatus.Deleted => "deleted",
                SnapshotStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnapshotStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => SnapshotStatus.Created,
                "deleted" => SnapshotStatus.Deleted,
                "failed" => SnapshotStatus.Failed,
                _ => null,
            };
        }
    }
}