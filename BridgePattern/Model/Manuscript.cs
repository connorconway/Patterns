namespace BridgePattern.Model
{
	public abstract class Manuscript
	{
		protected readonly IFormatter Formatter;

		public Manuscript(IFormatter formatter)
		{
			this.Formatter = formatter;
		}

		abstract public void Print();
	}
}