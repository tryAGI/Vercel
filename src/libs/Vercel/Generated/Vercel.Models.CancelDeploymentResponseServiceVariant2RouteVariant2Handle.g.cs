
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2RouteVariant2Handle
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
    public static class CancelDeploymentResponseServiceVariant2RouteVariant2HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2RouteVariant2Handle value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Error => "error",
                CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Filesystem => "filesystem",
                CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Hit => "hit",
                CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Miss => "miss",
                CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Resource => "resource",
                CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2RouteVariant2Handle? ToEnum(string value)
        {
            return value switch
            {
                "error" => CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Error,
                "filesystem" => CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Filesystem,
                "hit" => CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Hit,
                "miss" => CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Miss,
                "resource" => CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Resource,
                "rewrite" => CancelDeploymentResponseServiceVariant2RouteVariant2Handle.Rewrite,
                _ => null,
            };
        }
    }
}