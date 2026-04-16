
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The method used to create the snapshot.<br/>
    /// Example: manual
    /// </summary>
    public enum SnapshotCreationMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Automatic,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnapshotCreationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnapshotCreationMethod value)
        {
            return value switch
            {
                SnapshotCreationMethod.Automatic => "automatic",
                SnapshotCreationMethod.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnapshotCreationMethod? ToEnum(string value)
        {
            return value switch
            {
                "automatic" => SnapshotCreationMethod.Automatic,
                "manual" => SnapshotCreationMethod.Manual,
                _ => null,
            };
        }
    }
}