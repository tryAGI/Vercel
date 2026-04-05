
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectCheckResponseSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectCheckResponseSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectCheckResponseSourceVariant1Kind value)
        {
            return value switch
            {
                GetProjectCheckResponseSourceVariant1Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectCheckResponseSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => GetProjectCheckResponseSourceVariant1Kind.Integration,
                _ => null,
            };
        }
    }
}