
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitRepoVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2GitRepoVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitRepoVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitRepoVariant1Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitRepoVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => CreateDeploymentResponseVariant2GitRepoVariant1Type.Gitlab,
                _ => null,
            };
        }
    }
}