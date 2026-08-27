
#nullable enable

namespace Vercel
{
    /// <summary>
    /// VHS-readiness status, or `null` for a multi-platform index.
    /// </summary>
    public enum VcrImageListItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Preparing,
        /// <summary>
        ///
        /// </summary>
        Ready,
        /// <summary>
        ///
        /// </summary>
        Unoptimized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VcrImageListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageListItemStatus value)
        {
            return value switch
            {
                VcrImageListItemStatus.Preparing => "preparing",
                VcrImageListItemStatus.Ready => "ready",
                VcrImageListItemStatus.Unoptimized => "unoptimized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "preparing" => VcrImageListItemStatus.Preparing,
                "ready" => VcrImageListItemStatus.Ready,
                "unoptimized" => VcrImageListItemStatus.Unoptimized,
                _ => null,
            };
        }
    }
}