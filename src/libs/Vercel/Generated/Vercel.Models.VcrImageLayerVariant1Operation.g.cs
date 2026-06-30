
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Docker/OCI build instruction associated with an image layer.
    /// </summary>
    public enum VcrImageLayerVariant1Operation
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
    public static class VcrImageLayerVariant1OperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageLayerVariant1Operation value)
        {
            return value switch
            {
                VcrImageLayerVariant1Operation.Add => "ADD",
                VcrImageLayerVariant1Operation.Arg => "ARG",
                VcrImageLayerVariant1Operation.Cmd => "CMD",
                VcrImageLayerVariant1Operation.Copy => "COPY",
                VcrImageLayerVariant1Operation.Entrypoint => "ENTRYPOINT",
                VcrImageLayerVariant1Operation.Env => "ENV",
                VcrImageLayerVariant1Operation.Expose => "EXPOSE",
                VcrImageLayerVariant1Operation.From => "FROM",
                VcrImageLayerVariant1Operation.Healthcheck => "HEALTHCHECK",
                VcrImageLayerVariant1Operation.Label => "LABEL",
                VcrImageLayerVariant1Operation.Onbuild => "ONBUILD",
                VcrImageLayerVariant1Operation.Run => "RUN",
                VcrImageLayerVariant1Operation.Shell => "SHELL",
                VcrImageLayerVariant1Operation.Stopsignal => "STOPSIGNAL",
                VcrImageLayerVariant1Operation.Unknown => "UNKNOWN",
                VcrImageLayerVariant1Operation.User => "USER",
                VcrImageLayerVariant1Operation.Volume => "VOLUME",
                VcrImageLayerVariant1Operation.Workdir => "WORKDIR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageLayerVariant1Operation? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => VcrImageLayerVariant1Operation.Add,
                "ARG" => VcrImageLayerVariant1Operation.Arg,
                "CMD" => VcrImageLayerVariant1Operation.Cmd,
                "COPY" => VcrImageLayerVariant1Operation.Copy,
                "ENTRYPOINT" => VcrImageLayerVariant1Operation.Entrypoint,
                "ENV" => VcrImageLayerVariant1Operation.Env,
                "EXPOSE" => VcrImageLayerVariant1Operation.Expose,
                "FROM" => VcrImageLayerVariant1Operation.From,
                "HEALTHCHECK" => VcrImageLayerVariant1Operation.Healthcheck,
                "LABEL" => VcrImageLayerVariant1Operation.Label,
                "ONBUILD" => VcrImageLayerVariant1Operation.Onbuild,
                "RUN" => VcrImageLayerVariant1Operation.Run,
                "SHELL" => VcrImageLayerVariant1Operation.Shell,
                "STOPSIGNAL" => VcrImageLayerVariant1Operation.Stopsignal,
                "UNKNOWN" => VcrImageLayerVariant1Operation.Unknown,
                "USER" => VcrImageLayerVariant1Operation.User,
                "VOLUME" => VcrImageLayerVariant1Operation.Volume,
                "WORKDIR" => VcrImageLayerVariant1Operation.Workdir,
                _ => null,
            };
        }
    }
}