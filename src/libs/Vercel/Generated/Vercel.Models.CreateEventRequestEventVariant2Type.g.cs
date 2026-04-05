
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEventRequestEventVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ResourceUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEventRequestEventVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEventRequestEventVariant2Type value)
        {
            return value switch
            {
                CreateEventRequestEventVariant2Type.ResourceUpdated => "resource.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEventRequestEventVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "resource.updated" => CreateEventRequestEventVariant2Type.ResourceUpdated,
                _ => null,
            };
        }
    }
}