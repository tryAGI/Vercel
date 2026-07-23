
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type
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
    public static class GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type.Cookie => "cookie",
                GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type.Header => "header",
                GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type.Cookie,
                "header" => GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type.Header,
                "query" => GetDeploymentResponseVariant2ServiceVariant2RedirectMissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}