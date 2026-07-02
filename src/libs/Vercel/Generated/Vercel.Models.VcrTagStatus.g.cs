
#nullable enable

namespace Vercel
{
    /// <summary>
    /// VHS-readiness status, or `null` for a multi-platform index.
    /// </summary>
    public enum VcrTagStatus
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
    public static class VcrTagStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrTagStatus value)
        {
            return value switch
            {
                VcrTagStatus.Preparing => "preparing",
                VcrTagStatus.Ready => "ready",
                VcrTagStatus.Unoptimized => "unoptimized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrTagStatus? ToEnum(string value)
        {
            return value switch
            {
                "preparing" => VcrTagStatus.Preparing,
                "ready" => VcrTagStatus.Ready,
                "unoptimized" => VcrTagStatus.Unoptimized,
                _ => null,
            };
        }
    }
}