
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The workload type of this snapshot.
    /// </summary>
    public enum SnapshotWorkloadType
    {
        /// <summary>
        ///
        /// </summary>
        Sandbox,
        /// <summary>
        ///
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnapshotWorkloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnapshotWorkloadType value)
        {
            return value switch
            {
                SnapshotWorkloadType.Sandbox => "sandbox",
                SnapshotWorkloadType.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnapshotWorkloadType? ToEnum(string value)
        {
            return value switch
            {
                "sandbox" => SnapshotWorkloadType.Sandbox,
                "v0" => SnapshotWorkloadType.V0,
                _ => null,
            };
        }
    }
}