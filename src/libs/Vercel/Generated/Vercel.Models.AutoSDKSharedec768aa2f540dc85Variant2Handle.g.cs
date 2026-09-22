
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedec768aa2f540dc85Variant2Handle
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
    public static class AutoSDKSharedec768aa2f540dc85Variant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedec768aa2f540dc85Variant2Handle value)
        {
            return value switch
            {
                AutoSDKSharedec768aa2f540dc85Variant2Handle.Error => "error",
                AutoSDKSharedec768aa2f540dc85Variant2Handle.Filesystem => "filesystem",
                AutoSDKSharedec768aa2f540dc85Variant2Handle.Hit => "hit",
                AutoSDKSharedec768aa2f540dc85Variant2Handle.Miss => "miss",
                AutoSDKSharedec768aa2f540dc85Variant2Handle.Resource => "resource",
                AutoSDKSharedec768aa2f540dc85Variant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedec768aa2f540dc85Variant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => AutoSDKSharedec768aa2f540dc85Variant2Handle.Error,
                "filesystem" => AutoSDKSharedec768aa2f540dc85Variant2Handle.Filesystem,
                "hit" => AutoSDKSharedec768aa2f540dc85Variant2Handle.Hit,
                "miss" => AutoSDKSharedec768aa2f540dc85Variant2Handle.Miss,
                "resource" => AutoSDKSharedec768aa2f540dc85Variant2Handle.Resource,
                "rewrite" => AutoSDKSharedec768aa2f540dc85Variant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}