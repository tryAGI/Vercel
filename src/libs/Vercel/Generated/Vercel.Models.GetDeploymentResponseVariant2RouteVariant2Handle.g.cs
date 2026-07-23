
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2RouteVariant2Handle
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Filesystem,
        /// <summary>
        /// 
        /// </summary>
        Hit,
        /// <summary>
        /// 
        /// </summary>
        Miss,
        /// <summary>
        /// 
        /// </summary>
        Resource,
        /// <summary>
        /// 
        /// </summary>
        Rewrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2RouteVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2RouteVariant2Handle value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2RouteVariant2Handle.Error => "error",
                GetDeploymentResponseVariant2RouteVariant2Handle.Filesystem => "filesystem",
                GetDeploymentResponseVariant2RouteVariant2Handle.Hit => "hit",
                GetDeploymentResponseVariant2RouteVariant2Handle.Miss => "miss",
                GetDeploymentResponseVariant2RouteVariant2Handle.Resource => "resource",
                GetDeploymentResponseVariant2RouteVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2RouteVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDeploymentResponseVariant2RouteVariant2Handle.Error,
                "filesystem" => GetDeploymentResponseVariant2RouteVariant2Handle.Filesystem,
                "hit" => GetDeploymentResponseVariant2RouteVariant2Handle.Hit,
                "miss" => GetDeploymentResponseVariant2RouteVariant2Handle.Miss,
                "resource" => GetDeploymentResponseVariant2RouteVariant2Handle.Resource,
                "rewrite" => GetDeploymentResponseVariant2RouteVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}