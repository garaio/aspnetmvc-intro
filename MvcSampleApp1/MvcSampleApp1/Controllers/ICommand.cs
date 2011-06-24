using System.ComponentModel.DataAnnotations;

namespace MvcSampleApp1.Controllers
{
	public interface ICommand<TResult> : IValidatableObject
	{
		TResult Execute();
	}

	public interface ICommand : IValidatableObject
	{
		void Execute();
	}
}