
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type
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
    public static class CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type.Cookie => "cookie",
                CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type.Header => "header",
                CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type.Cookie,
                "header" => CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type.Header,
                "query" => CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}