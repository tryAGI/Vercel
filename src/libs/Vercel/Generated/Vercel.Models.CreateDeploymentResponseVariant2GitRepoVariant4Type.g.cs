
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitRepoVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2GitRepoVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitRepoVariant4Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitRepoVariant4Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitRepoVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => CreateDeploymentResponseVariant2GitRepoVariant4Type.Vercel,
                _ => null,
            };
        }
    }
}