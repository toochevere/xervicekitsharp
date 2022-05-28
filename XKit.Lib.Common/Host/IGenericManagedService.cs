using System;
using XKit.Lib.Common.Log;

namespace XKit.Lib.Common.Host
{
    public interface IGenericManagedService : IManagedService {

        /// <summary>
        /// Adds a daemon to this generic service
        /// </summary>
        /// <typeparam name="TMessage"></typeparam>
        void AddDaemon<TMessage>(
            IServiceDaemon<TMessage> daemon
        ) where TMessage : class;

        IGenericTimerDaemon AddGenericTimerDaemon<TDaemonOperation>(
            ILogSessionFactory logSessionFactory,
            int? timerDelayMilliseconds = null,
            string daemonName = null,
            Action<IGenericTimerDaemon> onEnvironmentChangeHandler = null
        ) where TDaemonOperation : IServiceDaemonOperation<object>;
    }
    
    public interface IGenericManagedService<TOperationConcrete> : IGenericManagedService {}
}
