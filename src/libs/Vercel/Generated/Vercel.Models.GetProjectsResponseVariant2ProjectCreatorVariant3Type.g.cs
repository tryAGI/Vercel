
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectCreatorVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectCreatorVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectCreatorVariant3Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectCreatorVariant3Type.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectCreatorVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "integration" => GetProjectsResponseVariant2ProjectCreatorVariant3Type.Integration,
                _ => null,
            };
        }
    }
}