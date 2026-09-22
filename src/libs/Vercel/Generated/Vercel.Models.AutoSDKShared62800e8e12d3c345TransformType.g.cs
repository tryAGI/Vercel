
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared62800e8e12d3c345TransformType
    {
        /// <summary>
        ///
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared62800e8e12d3c345TransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared62800e8e12d3c345TransformType value)
        {
            return value switch
            {
                AutoSDKShared62800e8e12d3c345TransformType.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared62800e8e12d3c345TransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => AutoSDKShared62800e8e12d3c345TransformType.RequestPath,
                _ => null,
            };
        }
    }
}