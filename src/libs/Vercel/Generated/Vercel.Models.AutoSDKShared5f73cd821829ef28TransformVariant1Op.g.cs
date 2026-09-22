
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5f73cd821829ef28TransformVariant1Op
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
    public static class AutoSDKShared5f73cd821829ef28TransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f73cd821829ef28TransformVariant1Op value)
        {
            return value switch
            {
                AutoSDKShared5f73cd821829ef28TransformVariant1Op.Append => "append",
                AutoSDKShared5f73cd821829ef28TransformVariant1Op.Delete => "delete",
                AutoSDKShared5f73cd821829ef28TransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f73cd821829ef28TransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => AutoSDKShared5f73cd821829ef28TransformVariant1Op.Append,
                "delete" => AutoSDKShared5f73cd821829ef28TransformVariant1Op.Delete,
                "set" => AutoSDKShared5f73cd821829ef28TransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}