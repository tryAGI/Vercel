
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentCheckRunsResponseRunSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunSourceVariant1Kind value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunSourceVariant1Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => ListDeploymentCheckRunsResponseRunSourceVariant1Kind.Integration,
                _ => null,
            };
        }
    }
}