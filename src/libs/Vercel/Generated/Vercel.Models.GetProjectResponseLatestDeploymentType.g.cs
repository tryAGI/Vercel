
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLatestDeploymentType
    {
        /// <summary>
        /// 
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseLatestDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLatestDeploymentType value)
        {
            return value switch
            {
                GetProjectResponseLatestDeploymentType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLatestDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => GetProjectResponseLatestDeploymentType.Lambdas,
                _ => null,
            };
        }
    }
}