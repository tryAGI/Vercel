
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4Type value)
        {
            return value switch
            {
                AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4Type.Experiment,
                _ => null,
            };
        }
    }
}