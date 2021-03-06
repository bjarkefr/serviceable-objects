﻿namespace Serviceable.Objects.Remote.Tests.Classes.Proxies
{
    using System.Threading.Tasks;
    using Serviceable.Objects.Remote.Proxying;

    public sealed class ProxyContext : Context<ProxyContext>, IProxyContext
    {
        public AbstractContext WrappedContext { get; }

        public ProxyContext(AbstractContext context)
        {
            WrappedContext = context;
        }

        public IRemotableCarrier<TContext, TOtherContext, TReceived> CreateRemotableCarrier<TContext, TOtherContext, TReceived>()
            where TOtherContext : Context<TOtherContext> where TContext : IProxyContext
        {
            return new RemotableCarrier<TContext, TOtherContext, TReceived>();
        }

        public IReproducibleCarrier<TContext, TContext, TOtherContext, TReceived> CreateReproducibleCarrier<TContext, TOtherContext, TReceived>()
            where TOtherContext : Context<TOtherContext> where TContext : IProxyContext
        {
            return new ReproducibleCarrier<TContext, TOtherContext, TReceived>();
        }

        public IReproducibleCarrier<TContext, Task<TContext> ,TOtherContext, TReceived> CreateAsyncReproducibleCarrier<TContext, TOtherContext, TReceived>()
            where TOtherContext : Context<TOtherContext> where TContext : IProxyContext
        {
            return new ReproducibleCarrier<TContext, TOtherContext, TReceived>();
        }
    }
}
