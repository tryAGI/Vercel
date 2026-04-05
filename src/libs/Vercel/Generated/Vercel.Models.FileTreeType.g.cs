
#nullable enable

namespace Vercel
{
    /// <summary>
    /// String indicating the type of file tree entry.<br/>
    /// Example: file
    /// </summary>
    public enum FileTreeType
    {
        /// <summary>
        /// 
        /// </summary>
        Directory,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        Middleware,
        /// <summary>
        /// 
        /// </summary>
        Symlink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileTreeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileTreeType value)
        {
            return value switch
            {
                FileTreeType.Directory => "directory",
                FileTreeType.File => "file",
                FileTreeType.Invalid => "invalid",
                FileTreeType.Lambda => "lambda",
                FileTreeType.Middleware => "middleware",
                FileTreeType.Symlink => "symlink",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileTreeType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => FileTreeType.Directory,
                "file" => FileTreeType.File,
                "invalid" => FileTreeType.Invalid,
                "lambda" => FileTreeType.Lambda,
                "middleware" => FileTreeType.Middleware,
                "symlink" => FileTreeType.Symlink,
                _ => null,
            };
        }
    }
}