
namespace Naizari.Roles
{
	public class Application: ApplicationBase
	{
		public Application(): base(){ }

        public override string ToString()
        {
            return this.ApplicationName;
        }
	}
}

