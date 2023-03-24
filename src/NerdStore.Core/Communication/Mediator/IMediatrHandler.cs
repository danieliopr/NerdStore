﻿using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommomMessages.DomainEvents;
using NerdStore.Core.Messages.CommomMessages.Notifications;

namespace NerdStore.Core.Communication.Mediator
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T evento) where T : Command;
        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
        Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent;
    }
}
