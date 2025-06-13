using Reqnroll;

namespace AmbiguousStepDefDemo;

[Binding]
public class Feature1StepDefinitions
{
    [Scope(Tag = "tag1")]
    [Scope(Tag = "tag2")]
    [Then("stuff happens")]
    public void ThenStuffHappens()
    {
        throw new PendingStepException();
    }
}
