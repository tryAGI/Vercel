
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759NodeVersion
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
    public static class AutoSDKSharedd9ba619caaa0a759NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759NodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x10X => "10.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x12X => "12.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x14X => "14.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x16X => "16.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x18X => "18.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x20X => "20.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x22X => "22.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x24X => "24.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x26X => "26.x",
                AutoSDKSharedd9ba619caaa0a759NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x10X,
                "12.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x12X,
                "14.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x14X,
                "16.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x16X,
                "18.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x18X,
                "20.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x20X,
                "22.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x22X,
                "24.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x24X,
                "26.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x26X,
                "8.10.x" => AutoSDKSharedd9ba619caaa0a759NodeVersion.x810X,
                _ => null,
            };
        }
    }
}