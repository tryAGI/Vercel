
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eNodeVersion
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
    public static class AutoSDKSharede27e7ff1aa86f19eNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eNodeVersion value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x10X => "10.x",
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x12X => "12.x",
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x14X => "14.x",
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x16X => "16.x",
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x18X => "18.x",
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x20X => "20.x",
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x22X => "22.x",
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x24X => "24.x",
                AutoSDKSharede27e7ff1aa86f19eNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x10X,
                "12.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x12X,
                "14.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x14X,
                "16.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x16X,
                "18.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x18X,
                "20.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x20X,
                "22.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x22X,
                "24.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x24X,
                "8.10.x" => AutoSDKSharede27e7ff1aa86f19eNodeVersion.x810X,
                _ => null,
            };
        }
    }
}