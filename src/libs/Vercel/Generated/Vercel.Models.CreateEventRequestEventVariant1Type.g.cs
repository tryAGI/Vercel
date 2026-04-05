
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEventRequestEventVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        InstallationUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEventRequestEventVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEventRequestEventVariant1Type value)
        {
            return value switch
            {
                CreateEventRequestEventVariant1Type.InstallationUpdated => "installation.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEventRequestEventVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "installation.updated" => CreateEventRequestEventVariant1Type.InstallationUpdated,
                _ => null,
            };
        }
    }
}