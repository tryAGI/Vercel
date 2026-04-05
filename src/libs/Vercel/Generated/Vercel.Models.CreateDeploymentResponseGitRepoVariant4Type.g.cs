
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitRepoVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitRepoVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitRepoVariant4Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitRepoVariant4Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitRepoVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => CreateDeploymentResponseGitRepoVariant4Type.Vercel,
                _ => null,
            };
        }
    }
}