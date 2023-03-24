using MediatR;
using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommomMessages.DomainEvents;
using NerdStore.Core.Messages.CommomMessages.Notifications;

namespace NerdStore.Core.Communication.Mediator
{
    public class MediatrHandler : IMediatrHandler
    {
        private readonly IMediator _mediator;

        public MediatrHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> EnviarComando<T>(T comando) where T : Command
        {
            return await _mediator.Send(comando); // O Send é um request
        }

        public Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent
        {
            throw new NotImplementedException();
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);// É uma notificacao de alguma coisa, nem sempre tem intençao de mudança
        }

        public async Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification
        {
            await _mediator.Publish(notificacao);
        }
    }
}
