namespace Microsoft.AutoGen.Abstractions;

public interface IAgent
{
    Task HandleEvent(CloudEvent item);
    Task PublishEvent(CloudEvent item);
}
