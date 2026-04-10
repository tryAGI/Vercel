
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}