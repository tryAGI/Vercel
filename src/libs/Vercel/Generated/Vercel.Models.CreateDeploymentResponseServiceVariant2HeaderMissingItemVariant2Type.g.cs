
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type
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
    public static class CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Cookie => "cookie",
                CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Header => "header",
                CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Cookie,
                "header" => CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Header,
                "query" => CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}