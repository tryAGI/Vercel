
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job
    {
        /// <summary>
        ///
        /// </summary>
        Turborepo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4JobExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job.Turborepo => "Turborepo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job? ToEnum(string value)
        {
            return value switch
            {
                "Turborepo" => AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job.Turborepo,
                _ => null,
            };
        }
    }
}