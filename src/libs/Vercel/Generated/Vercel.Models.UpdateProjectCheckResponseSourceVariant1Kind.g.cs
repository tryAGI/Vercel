
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectCheckResponseSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectCheckResponseSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectCheckResponseSourceVariant1Kind value)
        {
            return value switch
            {
                UpdateProjectCheckResponseSourceVariant1Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectCheckResponseSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => UpdateProjectCheckResponseSourceVariant1Kind.Integration,
                _ => null,
            };
        }
    }
}