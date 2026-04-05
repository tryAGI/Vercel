
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of the deployment.<br/>
    /// Example: LAMBDAS
    /// </summary>
    public enum GetDeploymentsResponseDeploymentType
    {
        /// <summary>
        /// 
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentType value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => GetDeploymentsResponseDeploymentType.Lambdas,
                _ => null,
            };
        }
    }
}