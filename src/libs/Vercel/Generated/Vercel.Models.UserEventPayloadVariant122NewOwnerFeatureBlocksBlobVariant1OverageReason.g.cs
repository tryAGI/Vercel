
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsUsage,
        /// <summary>
        /// 
        /// </summary>
        Artifacts,
        /// <summary>
        /// 
        /// </summary>
        Bandwidth,
        /// <summary>
        /// 
        /// </summary>
        BlobDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAdvancedRequests,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAvgSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalGetResponseObjectSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalSimpleRequests,
        /// <summary>
        /// 
        /// </summary>
        ConnectDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        DataCacheRead,
        /// <summary>
        /// 
        /// </summary>
        DataCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigRead,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeFunctionExecutionUnits,
        /// <summary>
        /// 
        /// </summary>
        EdgeMiddlewareInvocations,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequest,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequestAdditionalCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        ElasticConcurrencyBuildSlots,
        /// <summary>
        /// 
        /// </summary>
        FastDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        FastOriginTransfer,
        /// <summary>
        /// 
        /// </summary>
        FluidCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        FluidDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionInvocation,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheRead,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationTransformation,
        /// <summary>
        /// 
        /// </summary>
        LogDrainsVolume,
        /// <summary>
        /// 
        /// </summary>
        MonitoringMetric,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityEvent,
        /// <summary>
        /// 
        /// </summary>
        OnDemandConcurrencyMinutes,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheRead,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ServerlessFunctionExecution,
        /// <summary>
        /// 
        /// </summary>
        SourceImages,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspExcessBytes,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspRequests,
        /// <summary>
        /// 
        /// </summary>
        WafRateLimitRequest,
        /// <summary>
        /// 
        /// </summary>
        WebAnalyticsEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}