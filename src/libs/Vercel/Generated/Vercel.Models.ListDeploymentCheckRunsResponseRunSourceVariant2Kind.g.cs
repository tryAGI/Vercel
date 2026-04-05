
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunSourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentCheckRunsResponseRunSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunSourceVariant2Kind value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunSourceVariant2Kind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ListDeploymentCheckRunsResponseRunSourceVariant2Kind.Webhook,
                _ => null,
            };
        }
    }
}