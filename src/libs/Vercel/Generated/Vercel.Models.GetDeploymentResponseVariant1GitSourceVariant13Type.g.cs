
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1GitSourceVariant13Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1GitSourceVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1GitSourceVariant13Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1GitSourceVariant13Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1GitSourceVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => GetDeploymentResponseVariant1GitSourceVariant13Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}