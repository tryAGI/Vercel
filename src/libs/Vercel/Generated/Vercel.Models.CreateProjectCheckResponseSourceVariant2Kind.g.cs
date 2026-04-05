
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectCheckResponseSourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectCheckResponseSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckResponseSourceVariant2Kind value)
        {
            return value switch
            {
                CreateProjectCheckResponseSourceVariant2Kind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckResponseSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => CreateProjectCheckResponseSourceVariant2Kind.Webhook,
                _ => null,
            };
        }
    }
}