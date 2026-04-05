
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitRepoVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseGitRepoVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitRepoVariant4Type value)
        {
            return value switch
            {
                CancelDeploymentResponseGitRepoVariant4Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitRepoVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => CancelDeploymentResponseGitRepoVariant4Type.Vercel,
                _ => null,
            };
        }
    }
}