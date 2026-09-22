
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7882ff81487eef12Architecture
    {
        /// <summary>
        ///
        /// </summary>
        Arm64,
        /// <summary>
        ///
        /// </summary>
        X8664,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7882ff81487eef12ArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7882ff81487eef12Architecture value)
        {
            return value switch
            {
                AutoSDKShared7882ff81487eef12Architecture.Arm64 => "arm64",
                AutoSDKShared7882ff81487eef12Architecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7882ff81487eef12Architecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => AutoSDKShared7882ff81487eef12Architecture.Arm64,
                "x86_64" => AutoSDKShared7882ff81487eef12Architecture.X8664,
                _ => null,
            };
        }
    }
}