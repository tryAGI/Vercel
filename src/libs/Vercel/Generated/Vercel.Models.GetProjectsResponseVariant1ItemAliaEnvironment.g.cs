
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaEnvironment value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaEnvironment.Preview => "preview",
                GetProjectsResponseVariant1ItemAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectsResponseVariant1ItemAliaEnvironment.Preview,
                "production" => GetProjectsResponseVariant1ItemAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}