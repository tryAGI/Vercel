
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfcc5a22551853b26NodeVersion
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
    public static class AutoSDKSharedfcc5a22551853b26NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfcc5a22551853b26NodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedfcc5a22551853b26NodeVersion.x10X => "10.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x12X => "12.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x14X => "14.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x16X => "16.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x18X => "18.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x20X => "20.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x22X => "22.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x24X => "24.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x26X => "26.x",
                AutoSDKSharedfcc5a22551853b26NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfcc5a22551853b26NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x10X,
                "12.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x12X,
                "14.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x14X,
                "16.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x16X,
                "18.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x18X,
                "20.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x20X,
                "22.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x22X,
                "24.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x24X,
                "26.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x26X,
                "8.10.x" => AutoSDKSharedfcc5a22551853b26NodeVersion.x810X,
                _ => null,
            };
        }
    }
}