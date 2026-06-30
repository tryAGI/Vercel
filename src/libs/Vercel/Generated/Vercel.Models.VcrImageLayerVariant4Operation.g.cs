
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Docker/OCI build instruction associated with an image layer.
    /// </summary>
    public enum VcrImageLayerVariant4Operation
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Arg,
        /// <summary>
        /// 
        /// </summary>
        Cmd,
        /// <summary>
        /// 
        /// </summary>
        Copy,
        /// <summary>
        /// 
        /// </summary>
        Entrypoint,
        /// <summary>
        /// 
        /// </summary>
        Env,
        /// <summary>
        /// 
        /// </summary>
        Expose,
        /// <summary>
        /// 
        /// </summary>
        From,
        /// <summary>
        /// 
        /// </summary>
        Healthcheck,
        /// <summary>
        /// 
        /// </summary>
        Label,
        /// <summary>
        /// 
        /// </summary>
        Onbuild,
        /// <summary>
        /// 
        /// </summary>
        Run,
        /// <summary>
        /// 
        /// </summary>
        Shell,
        /// <summary>
        /// 
        /// </summary>
        Stopsignal,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Volume,
        /// <summary>
        /// 
        /// </summary>
        Workdir,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VcrImageLayerVariant4OperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageLayerVariant4Operation value)
        {
            return value switch
            {
                VcrImageLayerVariant4Operation.Add => "ADD",
                VcrImageLayerVariant4Operation.Arg => "ARG",
                VcrImageLayerVariant4Operation.Cmd => "CMD",
                VcrImageLayerVariant4Operation.Copy => "COPY",
                VcrImageLayerVariant4Operation.Entrypoint => "ENTRYPOINT",
                VcrImageLayerVariant4Operation.Env => "ENV",
                VcrImageLayerVariant4Operation.Expose => "EXPOSE",
                VcrImageLayerVariant4Operation.From => "FROM",
                VcrImageLayerVariant4Operation.Healthcheck => "HEALTHCHECK",
                VcrImageLayerVariant4Operation.Label => "LABEL",
                VcrImageLayerVariant4Operation.Onbuild => "ONBUILD",
                VcrImageLayerVariant4Operation.Run => "RUN",
                VcrImageLayerVariant4Operation.Shell => "SHELL",
                VcrImageLayerVariant4Operation.Stopsignal => "STOPSIGNAL",
                VcrImageLayerVariant4Operation.Unknown => "UNKNOWN",
                VcrImageLayerVariant4Operation.User => "USER",
                VcrImageLayerVariant4Operation.Volume => "VOLUME",
                VcrImageLayerVariant4Operation.Workdir => "WORKDIR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageLayerVariant4Operation? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => VcrImageLayerVariant4Operation.Add,
                "ARG" => VcrImageLayerVariant4Operation.Arg,
                "CMD" => VcrImageLayerVariant4Operation.Cmd,
                "COPY" => VcrImageLayerVariant4Operation.Copy,
                "ENTRYPOINT" => VcrImageLayerVariant4Operation.Entrypoint,
                "ENV" => VcrImageLayerVariant4Operation.Env,
                "EXPOSE" => VcrImageLayerVariant4Operation.Expose,
                "FROM" => VcrImageLayerVariant4Operation.From,
                "HEALTHCHECK" => VcrImageLayerVariant4Operation.Healthcheck,
                "LABEL" => VcrImageLayerVariant4Operation.Label,
                "ONBUILD" => VcrImageLayerVariant4Operation.Onbuild,
                "RUN" => VcrImageLayerVariant4Operation.Run,
                "SHELL" => VcrImageLayerVariant4Operation.Shell,
                "STOPSIGNAL" => VcrImageLayerVariant4Operation.Stopsignal,
                "UNKNOWN" => VcrImageLayerVariant4Operation.Unknown,
                "USER" => VcrImageLayerVariant4Operation.User,
                "VOLUME" => VcrImageLayerVariant4Operation.Volume,
                "WORKDIR" => VcrImageLayerVariant4Operation.Workdir,
                _ => null,
            };
        }
    }
}