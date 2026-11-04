
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2a71ce8831cd3f8Variant2Handle
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
    public static class AutoSDKShareda2a71ce8831cd3f8Variant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2a71ce8831cd3f8Variant2Handle value)
        {
            return value switch
            {
                AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Error => "error",
                AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Filesystem => "filesystem",
                AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Hit => "hit",
                AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Miss => "miss",
                AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Resource => "resource",
                AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2a71ce8831cd3f8Variant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Error,
                "filesystem" => AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Filesystem,
                "hit" => AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Hit,
                "miss" => AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Miss,
                "resource" => AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Resource,
                "rewrite" => AutoSDKShareda2a71ce8831cd3f8Variant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}