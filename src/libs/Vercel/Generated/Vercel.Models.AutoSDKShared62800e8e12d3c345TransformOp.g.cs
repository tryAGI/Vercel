
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared62800e8e12d3c345TransformOp
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared62800e8e12d3c345TransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared62800e8e12d3c345TransformOp value)
        {
            return value switch
            {
                AutoSDKShared62800e8e12d3c345TransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared62800e8e12d3c345TransformOp? ToEnum(string value)
        {
            return value switch
            {
                "set" => AutoSDKShared62800e8e12d3c345TransformOp.Set,
                _ => null,
            };
        }
    }
}