
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared947f69fa305d000eTransformVariant2Op
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared947f69fa305d000eTransformVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared947f69fa305d000eTransformVariant2Op value)
        {
            return value switch
            {
                AutoSDKShared947f69fa305d000eTransformVariant2Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared947f69fa305d000eTransformVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "set" => AutoSDKShared947f69fa305d000eTransformVariant2Op.Set,
                _ => null,
            };
        }
    }
}