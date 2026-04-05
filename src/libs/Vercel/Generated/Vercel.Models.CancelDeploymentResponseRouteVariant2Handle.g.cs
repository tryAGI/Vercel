
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseRouteVariant2Handle
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
    public static class CancelDeploymentResponseRouteVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseRouteVariant2Handle value)
        {
            return value switch
            {
                CancelDeploymentResponseRouteVariant2Handle.Error => "error",
                CancelDeploymentResponseRouteVariant2Handle.Filesystem => "filesystem",
                CancelDeploymentResponseRouteVariant2Handle.Hit => "hit",
                CancelDeploymentResponseRouteVariant2Handle.Miss => "miss",
                CancelDeploymentResponseRouteVariant2Handle.Resource => "resource",
                CancelDeploymentResponseRouteVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseRouteVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => CancelDeploymentResponseRouteVariant2Handle.Error,
                "filesystem" => CancelDeploymentResponseRouteVariant2Handle.Filesystem,
                "hit" => CancelDeploymentResponseRouteVariant2Handle.Hit,
                "miss" => CancelDeploymentResponseRouteVariant2Handle.Miss,
                "resource" => CancelDeploymentResponseRouteVariant2Handle.Resource,
                "rewrite" => CancelDeploymentResponseRouteVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}