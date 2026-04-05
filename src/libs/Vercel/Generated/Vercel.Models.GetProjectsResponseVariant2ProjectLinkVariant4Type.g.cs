
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectLinkVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectLinkVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectLinkVariant4Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectLinkVariant4Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectLinkVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => GetProjectsResponseVariant2ProjectLinkVariant4Type.Gitlab,
                _ => null,
            };
        }
    }
}