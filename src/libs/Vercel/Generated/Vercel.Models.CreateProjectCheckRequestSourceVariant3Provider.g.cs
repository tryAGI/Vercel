
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectCheckRequestSourceVariant3Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectCheckRequestSourceVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckRequestSourceVariant3Provider value)
        {
            return value switch
            {
                CreateProjectCheckRequestSourceVariant3Provider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckRequestSourceVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "github" => CreateProjectCheckRequestSourceVariant3Provider.Github,
                _ => null,
            };
        }
    }
}