
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4NodeVersion
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
    public static class AutoSDKSharedfe1f84289679c6c4NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4NodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x10X => "10.x",
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x12X => "12.x",
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x14X => "14.x",
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x16X => "16.x",
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x18X => "18.x",
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x20X => "20.x",
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x22X => "22.x",
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x24X => "24.x",
                AutoSDKSharedfe1f84289679c6c4NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x10X,
                "12.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x12X,
                "14.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x14X,
                "16.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x16X,
                "18.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x18X,
                "20.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x20X,
                "22.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x22X,
                "24.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x24X,
                "8.10.x" => AutoSDKSharedfe1f84289679c6c4NodeVersion.x810X,
                _ => null,
            };
        }
    }
}