
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant1SourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentCheckRunsResponseRunVariant1SourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant1SourceVariant2Kind value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant1SourceVariant2Kind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant1SourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ListDeploymentCheckRunsResponseRunVariant1SourceVariant2Kind.Webhook,
                _ => null,
            };
        }
    }
}