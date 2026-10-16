
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51NodeVersion
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
    public static class AutoSDKShared866bd5cb8fda1c51NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51NodeVersion value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x10X => "10.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x12X => "12.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x14X => "14.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x16X => "16.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x18X => "18.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x20X => "20.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x22X => "22.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x24X => "24.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x26X => "26.x",
                AutoSDKShared866bd5cb8fda1c51NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x10X,
                "12.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x12X,
                "14.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x14X,
                "16.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x16X,
                "18.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x18X,
                "20.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x20X,
                "22.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x22X,
                "24.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x24X,
                "26.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x26X,
                "8.10.x" => AutoSDKShared866bd5cb8fda1c51NodeVersion.x810X,
                _ => null,
            };
        }
    }
}