
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseLinkVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseLinkVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLinkVariant5Type value)
        {
            return value switch
            {
                CreateProjectResponseLinkVariant5Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLinkVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateProjectResponseLinkVariant5Type.Bitbucket,
                _ => null,
            };
        }
    }
}