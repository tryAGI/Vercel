
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitSourceVariant14Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitSourceVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitSourceVariant14Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitSourceVariant14Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitSourceVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => CreateDeploymentResponseGitSourceVariant14Type.GithubLimited,
                _ => null,
            };
        }
    }
}