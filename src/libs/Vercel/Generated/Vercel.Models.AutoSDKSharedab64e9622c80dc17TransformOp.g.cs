
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab64e9622c80dc17TransformOp
    {
        /// <summary>
        ///
        /// </summary>
        Append,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedab64e9622c80dc17TransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab64e9622c80dc17TransformOp value)
        {
            return value switch
            {
                AutoSDKSharedab64e9622c80dc17TransformOp.Append => "append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab64e9622c80dc17TransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => AutoSDKSharedab64e9622c80dc17TransformOp.Append,
                _ => null,
            };
        }
    }
}