
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitRepoVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseGitRepoVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitRepoVariant1Type value)
        {
            return value switch
            {
                CancelDeploymentResponseGitRepoVariant1Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitRepoVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => CancelDeploymentResponseGitRepoVariant1Type.Gitlab,
                _ => null,
            };
        }
    }
}