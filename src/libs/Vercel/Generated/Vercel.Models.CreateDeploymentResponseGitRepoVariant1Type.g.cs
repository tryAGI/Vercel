
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitRepoVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitRepoVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitRepoVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitRepoVariant1Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitRepoVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => CreateDeploymentResponseGitRepoVariant1Type.Gitlab,
                _ => null,
            };
        }
    }
}