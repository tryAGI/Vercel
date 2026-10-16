
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineSelection
    {
        /// <summary>
        ///
        /// </summary>
        Elastic,
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}