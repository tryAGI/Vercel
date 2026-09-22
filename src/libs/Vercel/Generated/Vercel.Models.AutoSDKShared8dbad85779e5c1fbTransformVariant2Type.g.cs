
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8dbad85779e5c1fbTransformVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8dbad85779e5c1fbTransformVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8dbad85779e5c1fbTransformVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared8dbad85779e5c1fbTransformVariant2Type.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8dbad85779e5c1fbTransformVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => AutoSDKShared8dbad85779e5c1fbTransformVariant2Type.RequestPath,
                _ => null,
            };
        }
    }
}