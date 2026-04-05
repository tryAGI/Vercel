
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Example: completed
    /// </summary>
    public enum CreateCheckResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Registered,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCheckResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCheckResponseStatus value)
        {
            return value switch
            {
                CreateCheckResponseStatus.Completed => "completed",
                CreateCheckResponseStatus.Registered => "registered",
                CreateCheckResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCheckResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateCheckResponseStatus.Completed,
                "registered" => CreateCheckResponseStatus.Registered,
                "running" => CreateCheckResponseStatus.Running,
                _ => null,
            };
        }
    }
}