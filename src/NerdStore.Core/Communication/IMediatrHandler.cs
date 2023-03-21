using NerdStore.Core.Messages;
namespace NerdStore.Core.Communication
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T evento) where T : Command;
    }
}
