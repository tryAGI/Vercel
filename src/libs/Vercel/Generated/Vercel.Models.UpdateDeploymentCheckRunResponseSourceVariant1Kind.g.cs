
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentCheckRunResponseSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseSourceVariant1Kind value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseSourceVariant1Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => UpdateDeploymentCheckRunResponseSourceVariant1Kind.Integration,
                _ => null,
            };
        }
    }
}