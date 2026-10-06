
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4Job
    {
        /// <summary>
        ///
        /// </summary>
        Turborepo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4JobExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4Job value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4Job.Turborepo => "Turborepo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4Job? ToEnum(string value)
        {
            return value switch
            {
                "Turborepo" => AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4Job.Turborepo,
                _ => null,
            };
        }
    }
}