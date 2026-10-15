
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447TransformOp
    {
        /// <summary>
        ///
        /// </summary>
        Append,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd474136b05e5e447TransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447TransformOp value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447TransformOp.Append => "append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447TransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => AutoSDKSharedd474136b05e5e447TransformOp.Append,
                _ => null,
            };
        }
    }
}