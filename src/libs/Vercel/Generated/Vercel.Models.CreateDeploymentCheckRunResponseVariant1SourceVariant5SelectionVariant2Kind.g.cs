
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2Kind value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2Kind.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "job" => CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2Kind.Job,
                _ => null,
            };
        }
    }
}