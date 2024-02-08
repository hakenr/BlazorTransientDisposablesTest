namespace BlazorTransientDisposables.Client
{
	public class TransientDisposableService	: IDisposable
	{
		public TransientDisposableService()
		{
			Console.WriteLine($"Created TransientDisposableService {GetHashCode()}");
		}

		public void DoSomething()
		{
			Console.WriteLine($"Doing something with TransientDisposableService {GetHashCode()}");
		}

		public void Dispose()
		{
			Console.WriteLine($"Disposed TransientDisposableService {GetHashCode()}");
		}
	}
}
