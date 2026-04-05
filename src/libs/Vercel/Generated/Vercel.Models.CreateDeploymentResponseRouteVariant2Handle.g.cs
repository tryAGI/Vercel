
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant2Handle
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
    public static class CreateDeploymentResponseRouteVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant2Handle value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant2Handle.Error => "error",
                CreateDeploymentResponseRouteVariant2Handle.Filesystem => "filesystem",
                CreateDeploymentResponseRouteVariant2Handle.Hit => "hit",
                CreateDeploymentResponseRouteVariant2Handle.Miss => "miss",
                CreateDeploymentResponseRouteVariant2Handle.Resource => "resource",
                CreateDeploymentResponseRouteVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateDeploymentResponseRouteVariant2Handle.Error,
                "filesystem" => CreateDeploymentResponseRouteVariant2Handle.Filesystem,
                "hit" => CreateDeploymentResponseRouteVariant2Handle.Hit,
                "miss" => CreateDeploymentResponseRouteVariant2Handle.Miss,
                "resource" => CreateDeploymentResponseRouteVariant2Handle.Resource,
                "rewrite" => CreateDeploymentResponseRouteVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}