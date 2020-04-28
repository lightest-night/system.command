using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Exceptions;

namespace LightestNight.System.Command
{
    public interface ICommandValidator<in TCommand>
    {
        /// <summary>
        /// Used to Validate a command
        /// </summary>
        /// <param name="command">The command to validate</param>
        /// <param name="cancellationToken">Any <see cref="CancellationToken" /> to use to marshal the request</param>
        /// <returns>An empty collection if no validation errors are found, or a collection of <see cref="InvariantError" /></returns>
        Task<IEnumerable<InvariantError>> Validate(TCommand command, CancellationToken cancellationToken);
    }
}