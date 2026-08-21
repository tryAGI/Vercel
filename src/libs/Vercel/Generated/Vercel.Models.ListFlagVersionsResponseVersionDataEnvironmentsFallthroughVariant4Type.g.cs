
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant4Type value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant4Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant4Type.Experiment,
                _ => null,
            };
        }
    }
}