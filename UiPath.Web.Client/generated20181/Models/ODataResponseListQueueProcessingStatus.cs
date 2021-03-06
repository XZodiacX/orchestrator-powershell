// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20181.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataResponseListQueueProcessingStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListQueueProcessingStatus class.
        /// </summary>
        public ODataResponseListQueueProcessingStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListQueueProcessingStatus class.
        /// </summary>
        public ODataResponseListQueueProcessingStatus(string odatacontext = default(string), IList<QueueProcessingStatus> value = default(IList<QueueProcessingStatus>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<QueueProcessingStatus> Value { get; set; }

    }
}
