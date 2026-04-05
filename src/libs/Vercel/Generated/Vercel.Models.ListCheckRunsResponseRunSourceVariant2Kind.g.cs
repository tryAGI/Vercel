
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunSourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunSourceVariant2Kind value)
        {
            return value switch
            {
                ListCheckRunsResponseRunSourceVariant2Kind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ListCheckRunsResponseRunSourceVariant2Kind.Webhook,
                _ => null,
            };
        }
    }
}