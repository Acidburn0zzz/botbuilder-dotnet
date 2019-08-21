﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder.Dialogs.Debugging
{
    public static partial class Extensions
    {
        public static async Task<Releaser> WithWaitAsync(this SemaphoreSlim semaphore, CancellationToken cancellationToken)
        {
            await semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
            return new Releaser(semaphore);
        }

        public struct Releaser : IDisposable
        {
            public Releaser(SemaphoreSlim semaphore)
            {
                Semaphore = semaphore ?? throw new ArgumentNullException(nameof(semaphore));
            }

            public SemaphoreSlim Semaphore { get; }

            public void Dispose()
            {
                Semaphore.Release();
            }
        }
    }
}
