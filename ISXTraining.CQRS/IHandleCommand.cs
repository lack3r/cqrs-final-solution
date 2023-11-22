using System.Collections;

namespace ISXTraining.CQRS
{
    public interface IHandleCommand<TCommand>
    {
        IEnumerable Handle(TCommand c);
    }
}
