
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaEnvironment
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
    public static class GetProjectsResponseVariant2ProjectAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaEnvironment value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaEnvironment.Preview => "preview",
                GetProjectsResponseVariant2ProjectAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectsResponseVariant2ProjectAliaEnvironment.Preview,
                "production" => GetProjectsResponseVariant2ProjectAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}