
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2RouteVariant2Handle
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
    public static class CreateDeploymentResponseServiceVariant2RouteVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2RouteVariant2Handle value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Error => "error",
                CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Filesystem => "filesystem",
                CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Hit => "hit",
                CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Miss => "miss",
                CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Resource => "resource",
                CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2RouteVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Error,
                "filesystem" => CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Filesystem,
                "hit" => CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Hit,
                "miss" => CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Miss,
                "resource" => CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Resource,
                "rewrite" => CreateDeploymentResponseServiceVariant2RouteVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}