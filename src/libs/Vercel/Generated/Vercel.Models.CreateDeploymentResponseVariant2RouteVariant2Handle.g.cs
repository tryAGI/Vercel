
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2RouteVariant2Handle
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
    public static class CreateDeploymentResponseVariant2RouteVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2RouteVariant2Handle value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2RouteVariant2Handle.Error => "error",
                CreateDeploymentResponseVariant2RouteVariant2Handle.Filesystem => "filesystem",
                CreateDeploymentResponseVariant2RouteVariant2Handle.Hit => "hit",
                CreateDeploymentResponseVariant2RouteVariant2Handle.Miss => "miss",
                CreateDeploymentResponseVariant2RouteVariant2Handle.Resource => "resource",
                CreateDeploymentResponseVariant2RouteVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2RouteVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateDeploymentResponseVariant2RouteVariant2Handle.Error,
                "filesystem" => CreateDeploymentResponseVariant2RouteVariant2Handle.Filesystem,
                "hit" => CreateDeploymentResponseVariant2RouteVariant2Handle.Hit,
                "miss" => CreateDeploymentResponseVariant2RouteVariant2Handle.Miss,
                "resource" => CreateDeploymentResponseVariant2RouteVariant2Handle.Resource,
                "rewrite" => CreateDeploymentResponseVariant2RouteVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}