
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfaf92fa84e99abddVariant2Handle
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
    public static class AutoSDKSharedfaf92fa84e99abddVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfaf92fa84e99abddVariant2Handle value)
        {
            return value switch
            {
                AutoSDKSharedfaf92fa84e99abddVariant2Handle.Error => "error",
                AutoSDKSharedfaf92fa84e99abddVariant2Handle.Filesystem => "filesystem",
                AutoSDKSharedfaf92fa84e99abddVariant2Handle.Hit => "hit",
                AutoSDKSharedfaf92fa84e99abddVariant2Handle.Miss => "miss",
                AutoSDKSharedfaf92fa84e99abddVariant2Handle.Resource => "resource",
                AutoSDKSharedfaf92fa84e99abddVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfaf92fa84e99abddVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => AutoSDKSharedfaf92fa84e99abddVariant2Handle.Error,
                "filesystem" => AutoSDKSharedfaf92fa84e99abddVariant2Handle.Filesystem,
                "hit" => AutoSDKSharedfaf92fa84e99abddVariant2Handle.Hit,
                "miss" => AutoSDKSharedfaf92fa84e99abddVariant2Handle.Miss,
                "resource" => AutoSDKSharedfaf92fa84e99abddVariant2Handle.Resource,
                "rewrite" => AutoSDKSharedfaf92fa84e99abddVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}