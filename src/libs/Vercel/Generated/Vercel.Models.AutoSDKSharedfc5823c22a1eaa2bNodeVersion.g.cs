
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfc5823c22a1eaa2bNodeVersion
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
    public static class AutoSDKSharedfc5823c22a1eaa2bNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfc5823c22a1eaa2bNodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x10X => "10.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x12X => "12.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x14X => "14.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x16X => "16.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x18X => "18.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x20X => "20.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x22X => "22.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x24X => "24.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x26X => "26.x",
                AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfc5823c22a1eaa2bNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x10X,
                "12.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x12X,
                "14.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x14X,
                "16.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x16X,
                "18.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x18X,
                "20.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x20X,
                "22.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x22X,
                "24.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x24X,
                "26.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x26X,
                "8.10.x" => AutoSDKSharedfc5823c22a1eaa2bNodeVersion.x810X,
                _ => null,
            };
        }
    }
}