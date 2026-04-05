
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentCheckRunResponseSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseSourceVariant1Kind value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseSourceVariant1Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => CreateDeploymentCheckRunResponseSourceVariant1Kind.Integration,
                _ => null,
            };
        }
    }
}