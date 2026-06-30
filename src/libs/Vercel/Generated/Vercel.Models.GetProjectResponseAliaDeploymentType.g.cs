
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAliaDeploymentType
    {
        /// <summary>
        /// 
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseAliaDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaDeploymentType value)
        {
            return value switch
            {
                GetProjectResponseAliaDeploymentType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => GetProjectResponseAliaDeploymentType.Lambdas,
                _ => null,
            };
        }
    }
}