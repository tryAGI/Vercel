
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitRepoVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseGitRepoVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitRepoVariant2Type value)
        {
            return value switch
            {
                CancelDeploymentResponseGitRepoVariant2Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitRepoVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => CancelDeploymentResponseGitRepoVariant2Type.Github,
                _ => null,
            };
        }
    }
}