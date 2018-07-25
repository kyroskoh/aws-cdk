using Amazon.CDK;
using Amazon.CDK.AWS.Route53.cloudformation.HealthCheckResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Route53.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html </remarks>
    [JsiiInterfaceProxy(typeof(IHealthCheckResourceProps), "@aws-cdk/aws-route53.cloudformation.HealthCheckResourceProps")]
    internal class HealthCheckResourcePropsProxy : DeputyBase, IHealthCheckResourceProps
    {
        private HealthCheckResourcePropsProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>``AWS::Route53::HealthCheck.HealthCheckConfig``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html#cfn-route53-healthcheck-healthcheckconfig </remarks>
        [JsiiProperty("healthCheckConfig", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-route53.cloudformation.HealthCheckResource.HealthCheckConfigProperty\"}]}}")]
        public virtual object HealthCheckConfig
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``AWS::Route53::HealthCheck.HealthCheckTags``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html#cfn-route53-healthcheck-healthchecktags </remarks>
        [JsiiProperty("healthCheckTags", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-route53.cloudformation.HealthCheckResource.HealthCheckTagProperty\"}]}}}}]},\"optional\":true}")]
        public virtual object HealthCheckTags
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }
    }
}