namespace Illallangi.TheTvDb
{
    public abstract class TheTvDbCmdlet : NinjectCmdlet<TheTvDbModule>
    {
    }

    public abstract class TheTvDbGetCmdlet<T> : TheTvDbCmdlet
    {
        protected T Get()
        {
            return Get<T>();
        }

        protected override void EndProcessing()
        {
            WriteObject(this.Get());
        }
    }

    public abstract class TheTvDbSetCmdlet<TObj, TInt> : TheTvDbCmdlet
    {
        protected TObj GetObject()
        {
            return Get<TObj>();
        }

        protected TInt GetInterface()
        {
            return Get<TInt>();
        }

        protected override void EndProcessing()
        {
            WriteObject(this.GetInterface());
        }
    }
}