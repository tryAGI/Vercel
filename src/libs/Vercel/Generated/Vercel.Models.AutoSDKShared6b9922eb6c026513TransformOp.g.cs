
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6b9922eb6c026513TransformOp
    {
        /// <summary>
        ///
        /// </summary>
        Append,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6b9922eb6c026513TransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6b9922eb6c026513TransformOp value)
        {
            return value switch
            {
                AutoSDKShared6b9922eb6c026513TransformOp.Append => "append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6b9922eb6c026513TransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => AutoSDKShared6b9922eb6c026513TransformOp.Append,
                _ => null,
            };
        }
    }
}