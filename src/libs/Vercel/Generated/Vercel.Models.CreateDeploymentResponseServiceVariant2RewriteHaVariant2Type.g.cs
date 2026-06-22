
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type
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
    public static class CreateDeploymentResponseServiceVariant2RewriteHaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type.Cookie => "cookie",
                CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type.Header => "header",
                CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type.Cookie,
                "header" => CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type.Header,
                "query" => CreateDeploymentResponseServiceVariant2RewriteHaVariant2Type.Query,
                _ => null,
            };
        }
    }
}