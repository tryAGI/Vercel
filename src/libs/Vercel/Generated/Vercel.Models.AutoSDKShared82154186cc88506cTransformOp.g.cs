
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared82154186cc88506cTransformOp
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared82154186cc88506cTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared82154186cc88506cTransformOp value)
        {
            return value switch
            {
                AutoSDKShared82154186cc88506cTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared82154186cc88506cTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "set" => AutoSDKShared82154186cc88506cTransformOp.Set,
                _ => null,
            };
        }
    }
}