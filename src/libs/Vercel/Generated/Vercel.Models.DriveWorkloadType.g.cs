
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The workload type of this drive.
    /// </summary>
    public enum DriveWorkloadType
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
    public static class DriveWorkloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriveWorkloadType value)
        {
            return value switch
            {
                DriveWorkloadType.Sandbox => "sandbox",
                DriveWorkloadType.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriveWorkloadType? ToEnum(string value)
        {
            return value switch
            {
                "sandbox" => DriveWorkloadType.Sandbox,
                "v0" => DriveWorkloadType.V0,
                _ => null,
            };
        }
    }
}