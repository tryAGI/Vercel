
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedada259eacea6cff6TransformVariant1Op
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
    public static class AutoSDKSharedada259eacea6cff6TransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedada259eacea6cff6TransformVariant1Op value)
        {
            return value switch
            {
                AutoSDKSharedada259eacea6cff6TransformVariant1Op.Append => "append",
                AutoSDKSharedada259eacea6cff6TransformVariant1Op.Delete => "delete",
                AutoSDKSharedada259eacea6cff6TransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedada259eacea6cff6TransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => AutoSDKSharedada259eacea6cff6TransformVariant1Op.Append,
                "delete" => AutoSDKSharedada259eacea6cff6TransformVariant1Op.Delete,
                "set" => AutoSDKSharedada259eacea6cff6TransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}