
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab64e9622c80dc17Handle
    {
        /// <summary>
        ///
        /// </summary>
        Finalize,
        /// <summary>
        ///
        /// </summary>
        Init,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedab64e9622c80dc17HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab64e9622c80dc17Handle value)
        {
            return value switch
            {
                AutoSDKSharedab64e9622c80dc17Handle.Finalize => "finalize",
                AutoSDKSharedab64e9622c80dc17Handle.Init => "init",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab64e9622c80dc17Handle? ToEnum(string value)
        {
            return value switch
            {
                "finalize" => AutoSDKSharedab64e9622c80dc17Handle.Finalize,
                "init" => AutoSDKSharedab64e9622c80dc17Handle.Init,
                _ => null,
            };
        }
    }
}