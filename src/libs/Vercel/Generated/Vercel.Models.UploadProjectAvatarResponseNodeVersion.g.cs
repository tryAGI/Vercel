
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseNodeVersion
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
    public static class UploadProjectAvatarResponseNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseNodeVersion value)
        {
            return value switch
            {
                UploadProjectAvatarResponseNodeVersion.x10X => "10.x",
                UploadProjectAvatarResponseNodeVersion.x12X => "12.x",
                UploadProjectAvatarResponseNodeVersion.x14X => "14.x",
                UploadProjectAvatarResponseNodeVersion.x16X => "16.x",
                UploadProjectAvatarResponseNodeVersion.x18X => "18.x",
                UploadProjectAvatarResponseNodeVersion.x20X => "20.x",
                UploadProjectAvatarResponseNodeVersion.x22X => "22.x",
                UploadProjectAvatarResponseNodeVersion.x24X => "24.x",
                UploadProjectAvatarResponseNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => UploadProjectAvatarResponseNodeVersion.x10X,
                "12.x" => UploadProjectAvatarResponseNodeVersion.x12X,
                "14.x" => UploadProjectAvatarResponseNodeVersion.x14X,
                "16.x" => UploadProjectAvatarResponseNodeVersion.x16X,
                "18.x" => UploadProjectAvatarResponseNodeVersion.x18X,
                "20.x" => UploadProjectAvatarResponseNodeVersion.x20X,
                "22.x" => UploadProjectAvatarResponseNodeVersion.x22X,
                "24.x" => UploadProjectAvatarResponseNodeVersion.x24X,
                "8.10.x" => UploadProjectAvatarResponseNodeVersion.x810X,
                _ => null,
            };
        }
    }
}