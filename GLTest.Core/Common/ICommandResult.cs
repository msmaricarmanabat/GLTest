namespace GLTest.Core.Common
{
    public interface ICommandResult<T> : IExecuteResult
    {
        T Result { get; }
    }

    public interface IExecuteResult
    {
        bool IsSuccessful { get; }
        (string Code, string Message)? Error { get; }
    }
}
