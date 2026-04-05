
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2GitSourceVariant13Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2GitSourceVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2GitSourceVariant13Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2GitSourceVariant13Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2GitSourceVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => GetDeploymentResponseVariant2GitSourceVariant13Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}