
#nullable enable

namespace Vercel
{
    /// <summary>
    /// CPU architecture required to restore the snapshot.
    /// </summary>
    public enum SnapshotArchitecture
    {
        /// <summary>
        ///
        /// </summary>
        Amd64,
        /// <summary>
        ///
        /// </summary>
        Arm64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnapshotArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnapshotArchitecture value)
        {
            return value switch
            {
                SnapshotArchitecture.Amd64 => "amd64",
                SnapshotArchitecture.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnapshotArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => SnapshotArchitecture.Amd64,
                "arm64" => SnapshotArchitecture.Arm64,
                _ => null,
            };
        }
    }
}