
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared34abcb2fd4803b5aVariant2Handle
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Filesystem,
        /// <summary>
        ///
        /// </summary>
        Hit,
        /// <summary>
        ///
        /// </summary>
        Miss,
        /// <summary>
        ///
        /// </summary>
        Resource,
        /// <summary>
        ///
        /// </summary>
        Rewrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared34abcb2fd4803b5aVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared34abcb2fd4803b5aVariant2Handle value)
        {
            return value switch
            {
                AutoSDKShared34abcb2fd4803b5aVariant2Handle.Error => "error",
                AutoSDKShared34abcb2fd4803b5aVariant2Handle.Filesystem => "filesystem",
                AutoSDKShared34abcb2fd4803b5aVariant2Handle.Hit => "hit",
                AutoSDKShared34abcb2fd4803b5aVariant2Handle.Miss => "miss",
                AutoSDKShared34abcb2fd4803b5aVariant2Handle.Resource => "resource",
                AutoSDKShared34abcb2fd4803b5aVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared34abcb2fd4803b5aVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => AutoSDKShared34abcb2fd4803b5aVariant2Handle.Error,
                "filesystem" => AutoSDKShared34abcb2fd4803b5aVariant2Handle.Filesystem,
                "hit" => AutoSDKShared34abcb2fd4803b5aVariant2Handle.Hit,
                "miss" => AutoSDKShared34abcb2fd4803b5aVariant2Handle.Miss,
                "resource" => AutoSDKShared34abcb2fd4803b5aVariant2Handle.Resource,
                "rewrite" => AutoSDKShared34abcb2fd4803b5aVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}