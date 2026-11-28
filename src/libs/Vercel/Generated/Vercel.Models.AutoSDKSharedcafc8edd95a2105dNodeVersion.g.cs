
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcafc8edd95a2105dNodeVersion
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
        x26X,
        /// <summary>
        ///
        /// </summary>
        x810X,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcafc8edd95a2105dNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcafc8edd95a2105dNodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x10X => "10.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x12X => "12.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x14X => "14.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x16X => "16.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x18X => "18.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x20X => "20.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x22X => "22.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x24X => "24.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x26X => "26.x",
                AutoSDKSharedcafc8edd95a2105dNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcafc8edd95a2105dNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x10X,
                "12.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x12X,
                "14.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x14X,
                "16.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x16X,
                "18.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x18X,
                "20.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x20X,
                "22.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x22X,
                "24.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x24X,
                "26.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x26X,
                "8.10.x" => AutoSDKSharedcafc8edd95a2105dNodeVersion.x810X,
                _ => null,
            };
        }
    }
}