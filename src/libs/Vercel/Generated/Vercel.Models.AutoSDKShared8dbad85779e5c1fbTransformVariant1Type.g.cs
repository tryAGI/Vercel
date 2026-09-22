
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8dbad85779e5c1fbTransformVariant1Type
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
    public static class AutoSDKShared8dbad85779e5c1fbTransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8dbad85779e5c1fbTransformVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared8dbad85779e5c1fbTransformVariant1Type.RequestHeaders => "request.headers",
                AutoSDKShared8dbad85779e5c1fbTransformVariant1Type.RequestQuery => "request.query",
                AutoSDKShared8dbad85779e5c1fbTransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8dbad85779e5c1fbTransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AutoSDKShared8dbad85779e5c1fbTransformVariant1Type.RequestHeaders,
                "request.query" => AutoSDKShared8dbad85779e5c1fbTransformVariant1Type.RequestQuery,
                "response.headers" => AutoSDKShared8dbad85779e5c1fbTransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}