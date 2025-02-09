namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Current job details of the migration item.</summary>
    public partial class CurrentJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICurrentJobDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICurrentJobDetailsInternal
    {

        /// <summary>Backing field for <see cref="JobId" /> property.</summary>
        private string _jobId;

        /// <summary>The ARM Id of the job being executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string JobId { get => this._jobId; }

        /// <summary>Backing field for <see cref="JobName" /> property.</summary>
        private string _jobName;

        /// <summary>The job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string JobName { get => this._jobName; }

        /// <summary>Internal Acessors for JobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICurrentJobDetailsInternal.JobId { get => this._jobId; set { {_jobId = value;} } }

        /// <summary>Internal Acessors for JobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICurrentJobDetailsInternal.JobName { get => this._jobName; set { {_jobName = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICurrentJobDetailsInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Creates an new <see cref="CurrentJobDetails" /> instance.</summary>
        public CurrentJobDetails()
        {

        }
    }
    /// Current job details of the migration item.
    public partial interface ICurrentJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The ARM Id of the job being executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the job being executed.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(string) })]
        string JobId { get;  }
        /// <summary>The job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The job name.",
        SerializedName = @"jobName",
        PossibleTypes = new [] { typeof(string) })]
        string JobName { get;  }
        /// <summary>The start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The start time of the job.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }

    }
    /// Current job details of the migration item.
    internal partial interface ICurrentJobDetailsInternal

    {
        /// <summary>The ARM Id of the job being executed.</summary>
        string JobId { get; set; }
        /// <summary>The job name.</summary>
        string JobName { get; set; }
        /// <summary>The start time of the job.</summary>
        global::System.DateTime? StartTime { get; set; }

    }
}