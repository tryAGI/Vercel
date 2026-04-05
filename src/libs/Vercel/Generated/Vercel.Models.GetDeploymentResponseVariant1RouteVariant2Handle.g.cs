
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1RouteVariant2Handle
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
    public static class GetDeploymentResponseVariant1RouteVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1RouteVariant2Handle value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1RouteVariant2Handle.Error => "error",
                GetDeploymentResponseVariant1RouteVariant2Handle.Filesystem => "filesystem",
                GetDeploymentResponseVariant1RouteVariant2Handle.Hit => "hit",
                GetDeploymentResponseVariant1RouteVariant2Handle.Miss => "miss",
                GetDeploymentResponseVariant1RouteVariant2Handle.Resource => "resource",
                GetDeploymentResponseVariant1RouteVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1RouteVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDeploymentResponseVariant1RouteVariant2Handle.Error,
                "filesystem" => GetDeploymentResponseVariant1RouteVariant2Handle.Filesystem,
                "hit" => GetDeploymentResponseVariant1RouteVariant2Handle.Hit,
                "miss" => GetDeploymentResponseVariant1RouteVariant2Handle.Miss,
                "resource" => GetDeploymentResponseVariant1RouteVariant2Handle.Resource,
                "rewrite" => GetDeploymentResponseVariant1RouteVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}