
#nullable enable

namespace Vercel
{
    /// <summary>
    /// VHS-readiness status, or `null` for a multi-platform index.
    /// </summary>
    public enum VcrImageDetailStatus
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
    public static class VcrImageDetailStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageDetailStatus value)
        {
            return value switch
            {
                VcrImageDetailStatus.Preparing => "preparing",
                VcrImageDetailStatus.Ready => "ready",
                VcrImageDetailStatus.Unoptimized => "unoptimized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageDetailStatus? ToEnum(string value)
        {
            return value switch
            {
                "preparing" => VcrImageDetailStatus.Preparing,
                "ready" => VcrImageDetailStatus.Ready,
                "unoptimized" => VcrImageDetailStatus.Unoptimized,
                _ => null,
            };
        }
    }
}