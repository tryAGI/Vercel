
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5f73cd821829ef28TransformVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        RequestHeaders,
        /// <summary>
        ///
        /// </summary>
        RequestQuery,
        /// <summary>
        ///
        /// </summary>
        ResponseHeaders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5f73cd821829ef28TransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f73cd821829ef28TransformVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared5f73cd821829ef28TransformVariant1Type.RequestHeaders => "request.headers",
                AutoSDKShared5f73cd821829ef28TransformVariant1Type.RequestQuery => "request.query",
                AutoSDKShared5f73cd821829ef28TransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f73cd821829ef28TransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AutoSDKShared5f73cd821829ef28TransformVariant1Type.RequestHeaders,
                "request.query" => AutoSDKShared5f73cd821829ef28TransformVariant1Type.RequestQuery,
                "response.headers" => AutoSDKShared5f73cd821829ef28TransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}