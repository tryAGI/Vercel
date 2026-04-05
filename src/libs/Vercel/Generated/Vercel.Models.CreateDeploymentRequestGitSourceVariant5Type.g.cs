
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentRequestGitSourceVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentRequestGitSourceVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestGitSourceVariant5Type value)
        {
            return value switch
            {
                CreateDeploymentRequestGitSourceVariant5Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestGitSourceVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => CreateDeploymentRequestGitSourceVariant5Type.GithubLimited,
                _ => null,
            };
        }
    }
}