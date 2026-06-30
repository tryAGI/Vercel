
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTargetsType
    {
        /// <summary>
        /// 
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseTargetsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTargetsType value)
        {
            return value switch
            {
                CreateProjectResponseTargetsType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTargetsType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => CreateProjectResponseTargetsType.Lambdas,
                _ => null,
            };
        }
    }
}