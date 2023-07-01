using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace _05.WorkflowCore.Workflows
{
    public class HelloBro : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine(nameof(HelloBro));

            return ExecutionResult.Next();
        }
    }
}