
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLinkVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseLinkVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLinkVariant4Type value)
        {
            return value switch
            {
                GetProjectResponseLinkVariant4Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLinkVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => GetProjectResponseLinkVariant4Type.Gitlab,
                _ => null,
            };
        }
    }
}