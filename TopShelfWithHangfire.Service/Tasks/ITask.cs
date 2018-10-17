namespace TopShelfWithHangfire.Service.Tasks
{
    public interface ITask
    {
        void Run();
        string Name { get; }
        string CronExpression { get; }
    }
}
