
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectCheckResponseSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectCheckResponseSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckResponseSourceVariant1Kind value)
        {
            return value switch
            {
                CreateProjectCheckResponseSourceVariant1Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckResponseSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => CreateProjectCheckResponseSourceVariant1Kind.Integration,
                _ => null,
            };
        }
    }
}