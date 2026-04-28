#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notification.toolkit.fluxcd.io;
/// <summary>Alert is the Schema for the alerts API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AlertList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Alert>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AlertList";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "alerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlertList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Alert objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Alert> Items { get; set; }
}

/// <summary>
/// EventSeverity specifies how to filter events based on severity.
/// If set to &apos;info&apos; no events will be filtered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AlertSpecEventSeverityEnum>))]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
public enum V1beta2AlertSpecEventSeverityEnum
{
    [EnumMember(Value = "info"), JsonStringEnumMemberName("info")]
    Info,
    [EnumMember(Value = "error"), JsonStringEnumMemberName("error")]
    Error
}

/// <summary>Kind of the referent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AlertSpecEventSourcesKindEnum>))]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
public enum V1beta2AlertSpecEventSourcesKindEnum
{
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    Bucket,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository,
    [EnumMember(Value = "Kustomization"), JsonStringEnumMemberName("Kustomization")]
    Kustomization,
    [EnumMember(Value = "HelmRelease"), JsonStringEnumMemberName("HelmRelease")]
    HelmRelease,
    [EnumMember(Value = "HelmChart"), JsonStringEnumMemberName("HelmChart")]
    HelmChart,
    [EnumMember(Value = "HelmRepository"), JsonStringEnumMemberName("HelmRepository")]
    HelmRepository,
    [EnumMember(Value = "ImageRepository"), JsonStringEnumMemberName("ImageRepository")]
    ImageRepository,
    [EnumMember(Value = "ImagePolicy"), JsonStringEnumMemberName("ImagePolicy")]
    ImagePolicy,
    [EnumMember(Value = "ImageUpdateAutomation"), JsonStringEnumMemberName("ImageUpdateAutomation")]
    ImageUpdateAutomation,
    [EnumMember(Value = "OCIRepository"), JsonStringEnumMemberName("OCIRepository")]
    OCIRepository,
    [EnumMember(Value = "ArtifactGenerator"), JsonStringEnumMemberName("ArtifactGenerator")]
    ArtifactGenerator,
    [EnumMember(Value = "ExternalArtifact"), JsonStringEnumMemberName("ExternalArtifact")]
    ExternalArtifact
}

/// <summary>
/// CrossNamespaceObjectReference contains enough information to let you locate the
/// typed referenced object at cluster level
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
public partial class V1beta2AlertSpecEventSources
{
    /// <summary>API version of the referent</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent</summary>
    [JsonPropertyName("kind")]
    public required V1beta2AlertSpecEventSourcesKindEnum Kind { get; set; }

    /// <summary>
    /// MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// MatchLabels requires the name to be set to `*`.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>
    /// Name of the referent
    /// If multiple resources are targeted `*` may be set.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ProviderRef specifies which Provider this Alert should use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
public partial class V1beta2AlertSpecProviderRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AlertSpec defines an alerting rule for events involving a list of objects.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
public partial class V1beta2AlertSpec
{
    /// <summary>
    /// EventMetadata is an optional field for adding metadata to events dispatched by the
    /// controller. This can be used for enhancing the context of the event. If a field
    /// would override one already present on the original event as generated by the emitter,
    /// then the override doesn&apos;t happen, i.e. the original value is preserved, and an info
    /// log is printed.
    /// </summary>
    [JsonPropertyName("eventMetadata")]
    public IDictionary<string, string>? EventMetadata { get; set; }

    /// <summary>
    /// EventSeverity specifies how to filter events based on severity.
    /// If set to &apos;info&apos; no events will be filtered.
    /// </summary>
    [JsonPropertyName("eventSeverity")]
    public V1beta2AlertSpecEventSeverityEnum? EventSeverity { get; set; }

    /// <summary>
    /// EventSources specifies how to filter events based
    /// on the involved object kind, name and namespace.
    /// </summary>
    [JsonPropertyName("eventSources")]
    public required IList<V1beta2AlertSpecEventSources> EventSources { get; set; }

    /// <summary>
    /// ExclusionList specifies a list of Golang regular expressions
    /// to be used for excluding messages.
    /// </summary>
    [JsonPropertyName("exclusionList")]
    public IList<string>? ExclusionList { get; set; }

    /// <summary>
    /// InclusionList specifies a list of Golang regular expressions
    /// to be used for including messages.
    /// </summary>
    [JsonPropertyName("inclusionList")]
    public IList<string>? InclusionList { get; set; }

    /// <summary>ProviderRef specifies which Provider this Alert should use.</summary>
    [JsonPropertyName("providerRef")]
    public required V1beta2AlertSpecProviderRef ProviderRef { get; set; }

    /// <summary>Summary holds a short description of the impact and affected cluster.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// Suspend tells the controller to suspend subsequent
    /// events handling for this Alert.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AlertStatusConditionsStatusEnum>))]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
public enum V1beta2AlertStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
public partial class V1beta2AlertStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1beta2AlertStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>AlertStatus defines the observed state of the Alert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
public partial class V1beta2AlertStatus
{
    /// <summary>Conditions holds the conditions for the Alert.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AlertStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last observed generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Alert is the Schema for the alerts API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Alert is deprecated, upgrade to v1beta3")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Alert : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AlertSpec?>, IStatus<V1beta2AlertStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Alert";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "alerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Alert";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AlertSpec defines an alerting rule for events involving a list of objects.</summary>
    [JsonPropertyName("spec")]
    public V1beta2AlertSpec? Spec { get; set; }

    /// <summary>AlertStatus defines the observed state of the Alert.</summary>
    [JsonPropertyName("status")]
    public V1beta2AlertStatus? Status { get; set; }
}