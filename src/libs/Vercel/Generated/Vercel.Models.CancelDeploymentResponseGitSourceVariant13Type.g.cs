
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitSourceVariant13Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseGitSourceVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitSourceVariant13Type value)
        {
            return value switch
            {
                CancelDeploymentResponseGitSourceVariant13Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitSourceVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => CancelDeploymentResponseGitSourceVariant13Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}