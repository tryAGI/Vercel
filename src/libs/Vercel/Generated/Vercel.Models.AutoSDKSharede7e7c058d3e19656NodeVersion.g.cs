
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7e7c058d3e19656NodeVersion
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
    public static class AutoSDKSharede7e7c058d3e19656NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7e7c058d3e19656NodeVersion value)
        {
            return value switch
            {
                AutoSDKSharede7e7c058d3e19656NodeVersion.x10X => "10.x",
                AutoSDKSharede7e7c058d3e19656NodeVersion.x12X => "12.x",
                AutoSDKSharede7e7c058d3e19656NodeVersion.x14X => "14.x",
                AutoSDKSharede7e7c058d3e19656NodeVersion.x16X => "16.x",
                AutoSDKSharede7e7c058d3e19656NodeVersion.x18X => "18.x",
                AutoSDKSharede7e7c058d3e19656NodeVersion.x20X => "20.x",
                AutoSDKSharede7e7c058d3e19656NodeVersion.x22X => "22.x",
                AutoSDKSharede7e7c058d3e19656NodeVersion.x24X => "24.x",
                AutoSDKSharede7e7c058d3e19656NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7e7c058d3e19656NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x10X,
                "12.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x12X,
                "14.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x14X,
                "16.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x16X,
                "18.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x18X,
                "20.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x20X,
                "22.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x22X,
                "24.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x24X,
                "8.10.x" => AutoSDKSharede7e7c058d3e19656NodeVersion.x810X,
                _ => null,
            };
        }
    }
}