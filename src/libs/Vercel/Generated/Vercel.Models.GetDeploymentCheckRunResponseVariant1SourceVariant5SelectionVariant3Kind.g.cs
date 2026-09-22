
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        Task,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant3Kind value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant3Kind.Task => "task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "task" => GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant3Kind.Task,
                _ => null,
            };
        }
    }
}