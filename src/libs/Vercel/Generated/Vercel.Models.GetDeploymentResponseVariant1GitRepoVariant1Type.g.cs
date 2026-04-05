
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1GitRepoVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1GitRepoVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1GitRepoVariant1Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1GitRepoVariant1Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1GitRepoVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => GetDeploymentResponseVariant1GitRepoVariant1Type.Gitlab,
                _ => null,
            };
        }
    }
}