
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion
    {
        /// <summary>
        ///
        /// </summary>
        x10X,
        /// <summary>
        ///
        /// </summary>
        x12X,
        /// <summary>
        ///
        /// </summary>
        x14X,
        /// <summary>
        ///
        /// </summary>
        x16X,
        /// <summary>
        ///
        /// </summary>
        x18X,
        /// <summary>
        ///
        /// </summary>
        x20X,
        /// <summary>
        ///
        /// </summary>
        x22X,
        /// <summary>
        ///
        /// </summary>
        x24X,
        /// <summary>
        ///
        /// </summary>
        x810X,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd5e5cf9c62b8ab7fNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x10X => "10.x",
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x12X => "12.x",
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x14X => "14.x",
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x16X => "16.x",
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x18X => "18.x",
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x20X => "20.x",
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x22X => "22.x",
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x24X => "24.x",
                AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x10X,
                "12.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x12X,
                "14.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x14X,
                "16.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x16X,
                "18.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x18X,
                "20.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x20X,
                "22.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x22X,
                "24.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x24X,
                "8.10.x" => AutoSDKSharedd5e5cf9c62b8ab7fNodeVersion.x810X,
                _ => null,
            };
        }
    }
}