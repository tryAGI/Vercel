
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestNodeVersion
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestNodeVersion value)
        {
            return value switch
            {
                UpdateProjectRequestNodeVersion.x10X => "10.x",
                UpdateProjectRequestNodeVersion.x12X => "12.x",
                UpdateProjectRequestNodeVersion.x14X => "14.x",
                UpdateProjectRequestNodeVersion.x16X => "16.x",
                UpdateProjectRequestNodeVersion.x18X => "18.x",
                UpdateProjectRequestNodeVersion.x20X => "20.x",
                UpdateProjectRequestNodeVersion.x22X => "22.x",
                UpdateProjectRequestNodeVersion.x24X => "24.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => UpdateProjectRequestNodeVersion.x10X,
                "12.x" => UpdateProjectRequestNodeVersion.x12X,
                "14.x" => UpdateProjectRequestNodeVersion.x14X,
                "16.x" => UpdateProjectRequestNodeVersion.x16X,
                "18.x" => UpdateProjectRequestNodeVersion.x18X,
                "20.x" => UpdateProjectRequestNodeVersion.x20X,
                "22.x" => UpdateProjectRequestNodeVersion.x22X,
                "24.x" => UpdateProjectRequestNodeVersion.x24X,
                _ => null,
            };
        }
    }
}