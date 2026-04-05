
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectChecksResponseCheckSourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectChecksResponseCheckSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectChecksResponseCheckSourceVariant2Kind value)
        {
            return value switch
            {
                ListProjectChecksResponseCheckSourceVariant2Kind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectChecksResponseCheckSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ListProjectChecksResponseCheckSourceVariant2Kind.Webhook,
                _ => null,
            };
        }
    }
}