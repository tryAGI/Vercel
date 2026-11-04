
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared947f69fa305d000eTransformVariant1Op
    {
        /// <summary>
        ///
        /// </summary>
        Append,
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared947f69fa305d000eTransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared947f69fa305d000eTransformVariant1Op value)
        {
            return value switch
            {
                AutoSDKShared947f69fa305d000eTransformVariant1Op.Append => "append",
                AutoSDKShared947f69fa305d000eTransformVariant1Op.Delete => "delete",
                AutoSDKShared947f69fa305d000eTransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared947f69fa305d000eTransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => AutoSDKShared947f69fa305d000eTransformVariant1Op.Append,
                "delete" => AutoSDKShared947f69fa305d000eTransformVariant1Op.Delete,
                "set" => AutoSDKShared947f69fa305d000eTransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}