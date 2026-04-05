
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectNodeVersion
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
    public static class GetProjectsResponseVariant3ProjectNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectNodeVersion value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectNodeVersion.x10X => "10.x",
                GetProjectsResponseVariant3ProjectNodeVersion.x12X => "12.x",
                GetProjectsResponseVariant3ProjectNodeVersion.x14X => "14.x",
                GetProjectsResponseVariant3ProjectNodeVersion.x16X => "16.x",
                GetProjectsResponseVariant3ProjectNodeVersion.x18X => "18.x",
                GetProjectsResponseVariant3ProjectNodeVersion.x20X => "20.x",
                GetProjectsResponseVariant3ProjectNodeVersion.x22X => "22.x",
                GetProjectsResponseVariant3ProjectNodeVersion.x24X => "24.x",
                GetProjectsResponseVariant3ProjectNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => GetProjectsResponseVariant3ProjectNodeVersion.x10X,
                "12.x" => GetProjectsResponseVariant3ProjectNodeVersion.x12X,
                "14.x" => GetProjectsResponseVariant3ProjectNodeVersion.x14X,
                "16.x" => GetProjectsResponseVariant3ProjectNodeVersion.x16X,
                "18.x" => GetProjectsResponseVariant3ProjectNodeVersion.x18X,
                "20.x" => GetProjectsResponseVariant3ProjectNodeVersion.x20X,
                "22.x" => GetProjectsResponseVariant3ProjectNodeVersion.x22X,
                "24.x" => GetProjectsResponseVariant3ProjectNodeVersion.x24X,
                "8.10.x" => GetProjectsResponseVariant3ProjectNodeVersion.x810X,
                _ => null,
            };
        }
    }
}