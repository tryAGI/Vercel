
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Cookie,
        /// <summary>
        ///
        /// </summary>
        Header,
        /// <summary>
        ///
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Cookie => "cookie",
                CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Header => "header",
                CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Cookie,
                "header" => CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Header,
                "query" => CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}