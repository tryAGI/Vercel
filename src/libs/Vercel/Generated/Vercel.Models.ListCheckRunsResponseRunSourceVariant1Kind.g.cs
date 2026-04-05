
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunSourceVariant1Kind value)
        {
            return value switch
            {
                ListCheckRunsResponseRunSourceVariant1Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => ListCheckRunsResponseRunSourceVariant1Kind.Integration,
                _ => null,
            };
        }
    }
}