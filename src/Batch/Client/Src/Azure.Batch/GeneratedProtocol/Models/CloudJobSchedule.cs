// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// A job schedule that allows recurring jobs by specifying when to run
    /// jobs and a specification used to create each job.
    /// </summary>
    public partial class CloudJobSchedule
    {
        /// <summary>
        /// Initializes a new instance of the CloudJobSchedule class.
        /// </summary>
        public CloudJobSchedule() { }

        /// <summary>
        /// Initializes a new instance of the CloudJobSchedule class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the schedule
        /// within the account.</param>
        /// <param name="displayName">The display name for the
        /// schedule.</param>
        /// <param name="url">The URL of the job schedule.</param>
        /// <param name="eTag">The ETag of the job schedule.</param>
        /// <param name="lastModified">The last modified time of the job
        /// schedule.</param>
        /// <param name="creationTime">The creation time of the job
        /// schedule.</param>
        /// <param name="state">The current state of the job schedule.</param>
        /// <param name="stateTransitionTime">The time at which the job
        /// schedule entered the current state.</param>
        /// <param name="previousState">The previous state of the job
        /// schedule.</param>
        /// <param name="previousStateTransitionTime">The time at which the job
        /// schedule entered its previous state.</param>
        /// <param name="schedule">The schedule according to which jobs will be
        /// created.</param>
        /// <param name="jobSpecification">The details of the jobs to be
        /// created on this schedule.</param>
        /// <param name="executionInfo">Information about jobs that have been
        /// and will be run under this schedule.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the schedule as metadata.</param>
        /// <param name="stats">The lifetime resource usage statistics for the
        /// job schedule.</param>
        public CloudJobSchedule(string id = default(string), string displayName = default(string), string url = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), JobScheduleState? state = default(JobScheduleState?), System.DateTime? stateTransitionTime = default(System.DateTime?), JobScheduleState? previousState = default(JobScheduleState?), System.DateTime? previousStateTransitionTime = default(System.DateTime?), Schedule schedule = default(Schedule), JobSpecification jobSpecification = default(JobSpecification), JobScheduleExecutionInformation executionInfo = default(JobScheduleExecutionInformation), System.Collections.Generic.IList<MetadataItem> metadata = default(System.Collections.Generic.IList<MetadataItem>), JobScheduleStatistics stats = default(JobScheduleStatistics))
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            Schedule = schedule;
            JobSpecification = jobSpecification;
            ExecutionInfo = executionInfo;
            Metadata = metadata;
            Stats = stats;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the schedule within
        /// the account.
        /// </summary>
        /// <remarks>
        /// It is common to use a GUID for the id.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the job schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the job schedule.
        /// </summary>
        /// <remarks>
        /// This is an opaque string. You can use it to detect whether the job
        /// schedule has changed between requests. In particular, you can be
        /// pass the ETag with an Update Job Schedule request to specify that
        /// your changes should take effect only if nobody else has modified
        /// the schedule in the meantime.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the job schedule.
        /// </summary>
        /// <remarks>
        /// This is the last time at which the schedule level data, such as the
        /// job specification or recurrence information, changed. It does not
        /// factor in job-level changes such as new jobs being created or jobs
        /// changing state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the job schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the job schedule.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'completed', 'disabled',
        /// 'terminating', 'deleting'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public JobScheduleState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job schedule entered the current
        /// state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the job schedule.
        /// </summary>
        /// <remarks>
        /// This property is not present if the job schedule is in its initial
        /// active state. Possible values include: 'active', 'completed',
        /// 'disabled', 'terminating', 'deleting'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "previousState")]
        public JobScheduleState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job schedule entered its
        /// previous state.
        /// </summary>
        /// <remarks>
        /// This property is not present if the job schedule is in its initial
        /// active state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "previousStateTransitionTime")]
        public System.DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the schedule according to which jobs will be created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or sets the details of the jobs to be created on this
        /// schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobSpecification")]
        public JobSpecification JobSpecification { get; set; }

        /// <summary>
        /// Gets or sets information about jobs that have been and will be run
        /// under this schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executionInfo")]
        public JobScheduleExecutionInformation ExecutionInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the
        /// schedule as metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the lifetime resource usage statistics for the job
        /// schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stats")]
        public JobScheduleStatistics Stats { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.JobSpecification != null)
            {
                this.JobSpecification.Validate();
            }
            if (this.Metadata != null)
            {
                foreach (var element in this.Metadata)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Stats != null)
            {
                this.Stats.Validate();
            }
        }
    }
}
