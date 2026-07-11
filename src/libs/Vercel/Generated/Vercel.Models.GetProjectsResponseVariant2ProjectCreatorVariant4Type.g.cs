
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectCreatorVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectCreatorVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectCreatorVariant4Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectCreatorVariant4Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectCreatorVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => GetProjectsResponseVariant2ProjectCreatorVariant4Type.System,
                _ => null,
            };
        }
    }
}