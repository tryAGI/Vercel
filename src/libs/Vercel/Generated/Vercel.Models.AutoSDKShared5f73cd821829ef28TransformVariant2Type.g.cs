
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5f73cd821829ef28TransformVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5f73cd821829ef28TransformVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f73cd821829ef28TransformVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared5f73cd821829ef28TransformVariant2Type.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f73cd821829ef28TransformVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => AutoSDKShared5f73cd821829ef28TransformVariant2Type.RequestPath,
                _ => null,
            };
        }
    }
}