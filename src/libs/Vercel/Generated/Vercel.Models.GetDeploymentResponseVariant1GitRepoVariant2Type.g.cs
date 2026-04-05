
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1GitRepoVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1GitRepoVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1GitRepoVariant2Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1GitRepoVariant2Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1GitRepoVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => GetDeploymentResponseVariant1GitRepoVariant2Type.Github,
                _ => null,
            };
        }
    }
}