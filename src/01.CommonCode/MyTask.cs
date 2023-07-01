namespace Exercise.CommonCode
{
    public class MyTask<T> : Task where T : Task
    {
        public T TObject { get; set; } = default!;

        public MyTask(Action action) : base(action)
        {
            Run(action);
        }

        public override string ToString()
        {
            return $"Status: {TObject.Status}";
        }
    }

    public class CustomTask : Task
    {
        public CustomTask(Action action) : base(action)
        {
            Run(action);
        }
    }
}
