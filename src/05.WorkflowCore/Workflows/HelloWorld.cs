using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace _05.WorkflowCore.Workflows
{
    public class HelloWorld : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine(nameof(HelloWorld));

            return ExecutionResult.Next();
        }
    }
}