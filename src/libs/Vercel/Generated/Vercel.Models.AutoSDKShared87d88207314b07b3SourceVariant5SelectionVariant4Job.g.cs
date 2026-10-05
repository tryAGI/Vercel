
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d88207314b07b3SourceVariant5SelectionVariant4Job
    {
        /// <summary>
        ///
        /// </summary>
        Turborepo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared87d88207314b07b3SourceVariant5SelectionVariant4JobExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d88207314b07b3SourceVariant5SelectionVariant4Job value)
        {
            return value switch
            {
                AutoSDKShared87d88207314b07b3SourceVariant5SelectionVariant4Job.Turborepo => "Turborepo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d88207314b07b3SourceVariant5SelectionVariant4Job? ToEnum(string value)
        {
            return value switch
            {
                "Turborepo" => AutoSDKShared87d88207314b07b3SourceVariant5SelectionVariant4Job.Turborepo,
                _ => null,
            };
        }
    }
}