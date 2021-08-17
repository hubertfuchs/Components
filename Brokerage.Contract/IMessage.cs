using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract
{
    public interface IMessage
    {
        Guid Id { get; }
    }
}