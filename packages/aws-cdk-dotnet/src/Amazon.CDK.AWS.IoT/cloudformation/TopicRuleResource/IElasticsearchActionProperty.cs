using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.IoT.cloudformation.TopicRuleResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html </remarks>
    [JsiiInterface(typeof(IElasticsearchActionProperty), "@aws-cdk/aws-iot.cloudformation.TopicRuleResource.ElasticsearchActionProperty")]
    public interface IElasticsearchActionProperty
    {
        /// <summary>``TopicRuleResource.ElasticsearchActionProperty.Endpoint``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-endpoint </remarks>
        [JsiiProperty("endpoint", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Endpoint
        {
            get;
            set;
        }

        /// <summary>``TopicRuleResource.ElasticsearchActionProperty.Id``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-id </remarks>
        [JsiiProperty("id", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Id
        {
            get;
            set;
        }

        /// <summary>``TopicRuleResource.ElasticsearchActionProperty.Index``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-index </remarks>
        [JsiiProperty("index", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Index
        {
            get;
            set;
        }

        /// <summary>``TopicRuleResource.ElasticsearchActionProperty.RoleArn``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-rolearn </remarks>
        [JsiiProperty("roleArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object RoleArn
        {
            get;
            set;
        }

        /// <summary>``TopicRuleResource.ElasticsearchActionProperty.Type``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-type </remarks>
        [JsiiProperty("type", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Type
        {
            get;
            set;
        }
    }
}